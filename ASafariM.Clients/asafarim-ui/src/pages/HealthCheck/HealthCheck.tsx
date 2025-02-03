import React, { useEffect, useState } from "react";
import Layout from "../../layout/Layout";
import Footer from "../../layout/Footer/Footer";
import apiUrls from "@/api/getApiUrls";
import "./HealthCheck.css";

interface HealthStatus {
  status: string;
  version: string;
  timestamp: string;
  services?: {
    database: string;
    cache: string;
    api: string;
  };
  uptime?: string;
  memoryUsage?: {
    totalAllocated: string;
    used: string;
    workingSet: string;
    peakPagedMemory: string;
  };
  cpuUsage?: string;
  diskSpace?: {
    name: string;
    totalSpace: string;
    freeSpace: string;
  };
  environment?: {
    machineName: string;
    osVersion: string;
    frameworkVersion: string;
    processArchitecture: string;
  };
  activeThreads?: {
    threadCount: number;
  };
}

const formatValue = (value: string | number) => {
  if (typeof value === 'number') {
    return value.toFixed(2);
  }
  return value;
};

const HealthCheck: React.FC = () => {
  const [healthData, setHealthData] = useState<HealthStatus | null>(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    const fetchHealthStatus = async () => {
      const baseUrl = apiUrls(window.location.hostname);
      try {
        const response = await fetch(`${baseUrl}/health`);
        if (!response.ok) {
          throw new Error("Health check failed");
        }
        const data = await response.json();
        setHealthData(data);
      } catch (err) {
        setError(
          err instanceof Error ? err.message : "Failed to fetch health status"
        );
      } finally {
        setLoading(false);
      }
    };

    fetchHealthStatus();
    const interval = setInterval(fetchHealthStatus, 30000);
    return () => clearInterval(interval);
  }, []);

  if (loading) {
    return (
      <Layout header={<></>} footer={<Footer />}>
        <div className="health-check__loading">
          <div className="health-check__spinner"></div>
        </div>
      </Layout>
    );
  }

  if (error) {
    return (
      <Layout header={<></>} footer={<Footer />}>
        <div className="health-check__container">
          <div className="health-check__error">
            <p>{error}</p>
          </div>
        </div>
      </Layout>
    );
  }

  const cUsage = healthData?.cpuUsage;

  return (
    <Layout header={<></>} footer={<Footer />}>
      <div className="health-check__container">
        <div className="health-check__content">
          <h1 className="health-check__title">System Health Status</h1>

          {healthData && (
            <div className="health-check__grid">
              <div className="health-check__status">
                <div
                  className={`health-check__status-indicator ${healthData.status === "healthy" ? "healthy" : "unhealthy"
                    }`}
                ></div>
                <span className="health-check__status-text">
                  System Status: {healthData.status}
                </span>
              </div>

              <div className="health-check__card">
                <h2>System Info</h2>
                <p>
                  <span>Version</span>
                  <span>{healthData.version}</span>
                </p>
                <p>
                  <span>Last Updated</span>
                  <span>{new Date(healthData.timestamp).toLocaleString()}</span>
                </p>
                {healthData.uptime && (
                  <p>
                    <span>Uptime</span>
                    <span>{healthData.uptime}</span>
                  </p>
                )}
              </div>

              {healthData.services && (
                <div className="health-check__card">
                  <h2>Services Status</h2>
                  <p>
                    <span>Database</span>
                    <span>{healthData.services.database}</span>
                  </p>
                  <p>
                    <span>Cache</span>
                    <span>{healthData.services.cache}</span>
                  </p>
                  <p>
                    <span>API</span>
                    <span>{healthData.services.api}</span>
                  </p>
                </div>
              )}

              {
                <div className="health-check__card">
                  <h2>CPU Usage</h2>
                  <div className="health-check__cpu-usage">
                    <div className="cpu-usage-indicator">
                      <div
                        className="cpu-usage-fill"
                        style={{ width: cUsage ? `${Math.min(parseFloat(cUsage), 100)}%` : '2%' }}
                      ></div>
                    </div>
                    <p>
                      <span>Current Usage</span>
                      {cUsage ? <span className={`cpu-value ${parseFloat(cUsage) > 80 ? 'high' : parseFloat(cUsage) > 50 ? 'medium' : 'low'}`}>
                        {formatValue(cUsage)}%
                      </span> : 'N/A'}
                    </p>
                  </div>
                </div>
              }

              {healthData.memoryUsage && (
                <div className="health-check__card">
                  <h2>Memory Usage</h2>
                  <div className="health-check__memory-grid">
                    <div>
                      <p className="label">Total Allocated</p>
                      <p className="value">{healthData.memoryUsage.totalAllocated}</p>
                    </div>
                    <div>
                      <p className="label">Used</p>
                      <p className="value">{healthData.memoryUsage.used}</p>
                    </div>
                    <div>
                      <p className="label">Working Set</p>
                      <p className="value">{healthData.memoryUsage.workingSet}</p>
                    </div>
                    <div>
                      <p className="label">Peak Usage</p>
                      <p className="value">{healthData.memoryUsage.peakPagedMemory}</p>
                    </div>
                  </div>
                </div>
              )}

              {healthData.diskSpace && (
                <div className="health-check__card">
                  <h2>Disk Space</h2>
                  <p>
                    <span>Drive</span>
                    <span>{healthData.diskSpace.name}</span>
                  </p>
                  <p>
                    <span>Total Space</span>
                    <span>{healthData.diskSpace.totalSpace}</span>
                  </p>
                  <p>
                    <span>Free Space</span>
                    <span>{healthData.diskSpace.freeSpace}</span>
                  </p>
                </div>
              )}

              {healthData.environment && (
                <div className="health-check__card">
                  <h2>Environment</h2>
                  <p>
                    <span>Machine</span>
                    <span>{healthData.environment.machineName}</span>
                  </p>
                  <p>
                    <span>OS</span>
                    <span>{healthData.environment.osVersion}</span>
                  </p>
                  <p>
                    <span>Framework</span>
                    <span>{healthData.environment.frameworkVersion}</span>
                  </p>
                  <p>
                    <span>Architecture</span>
                    <span>{healthData.environment.processArchitecture}</span>
                  </p>
                </div>
              )}

              {healthData.activeThreads && (
                <div className="health-check__card">
                  <h2>Active Threads</h2>
                  <p>
                    <span>Thread Count</span>
                    <span>{healthData.activeThreads.threadCount}</span>
                  </p>
                </div>
              )}
            </div>
          )}
        </div>
      </div>
    </Layout>
  );
};

export default HealthCheck;
