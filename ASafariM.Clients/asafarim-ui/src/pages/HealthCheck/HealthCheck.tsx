import React, { useEffect, useState } from "react";
import Layout from "../../layout/Layout";
import Footer from "../../layout/Footer/Footer";
import apiUrls from "@/api/getApiUrls";

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

const HealthCheck: React.FC = () => {
  const [healthData, setHealthData] = useState<HealthStatus | null>(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    const fetchHealthStatus = async () => {
      const baseUrl = apiUrls(window.location.hostname);
      try {
        const response = await fetch(`${baseUrl}/api/health`);
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
        <div className="flex items-center justify-center min-h-screen">
          <div className="animate-spin rounded-full h-12 w-12 border-t-2 border-b-2 border-blue-500"></div>
        </div>
      </Layout>
    );
  }

  if (error) {
    return (
      <Layout header={<></>} footer={<Footer />}>
        <div className="min-h-screen p-6">
          <div className="bg-red-100 border border-red-400 text-red-700 px-4 py-3 rounded">
            <p>{error}</p>
          </div>
        </div>
      </Layout>
    );
  }

  return (
    <Layout header={<></>} footer={<Footer />}>
      <div className="min-h-screen p-6">
        <div className="max-w-4xl mx-auto bg-white rounded-lg shadow-lg p-6">
          <h1 className="text-2xl font-bold mb-6">System Health Status</h1>

          {healthData && (
            <div className="space-y-6">
              <div className="flex items-center">
                <div
                  className={`h-4 w-4 rounded-full mr-2 ${
                    healthData.status === "healthy"
                      ? "bg-green-500"
                      : "bg-red-500"
                  }`}
                ></div>
                <span className="text-lg font-semibold">
                  Status: {healthData.status}
                </span>
              </div>

              <div className="grid grid-cols-1 md:grid-cols-2 gap-6">
                {/* System Info */}
                <div className="bg-gray-50 p-4 rounded-lg">
                  <h2 className="font-semibold mb-2">System Info</h2>
                  <p>Version: {healthData.version}</p>
                  <p>
                    Last Updated:{" "}
                    {new Date(healthData.timestamp).toLocaleString()}
                  </p>
                  {healthData.uptime && <p>Uptime: {healthData.uptime}</p>}
                </div>

                {/* Services Status */}
                {healthData.services && (
                  <div className="bg-gray-50 p-4 rounded-lg">
                    <h2 className="font-semibold mb-2">Services Status</h2>
                    <p>Database: {healthData.services.database}</p>
                    <p>Cache: {healthData.services.cache}</p>
                    <p>API: {healthData.services.api}</p>
                  </div>
                )}

                {/* Memory Usage */}
                {healthData.memoryUsage && (
                  <div className="bg-gray-50 p-4 rounded-lg col-span-full">
                    <h2 className="font-semibold mb-2">Memory Usage</h2>
                    <div className="grid grid-cols-2 md:grid-cols-4 gap-4">
                      <div>
                        <p className="text-sm text-gray-600">Total Allocated</p>
                        <p>{healthData.memoryUsage.totalAllocated}</p>
                      </div>
                      <div>
                        <p className="text-sm text-gray-600">Used</p>
                        <p>{healthData.memoryUsage.used}</p>
                      </div>
                      <div>
                        <p className="text-sm text-gray-600">Working Set</p>
                        <p>{healthData.memoryUsage.workingSet}</p>
                      </div>
                      <div>
                        <p className="text-sm text-gray-600">Peak Usage</p>
                        <p>{healthData.memoryUsage.peakPagedMemory}</p>
                      </div>
                    </div>
                  </div>
                )}

                {/* CPU Usage */}
                {healthData.cpuUsage && (
                  <div className="bg-gray-50 p-4 rounded-lg">
                    <h2 className="font-semibold mb-2">CPU Usage</h2>
                    <p>{healthData.cpuUsage}</p>
                  </div>
                )}

                {/* Disk Space */}
                {healthData.diskSpace && (
                  <div className="bg-gray-50 p-4 rounded-lg">
                    <h2 className="font-semibold mb-2">Disk Space</h2>
                    <p>Drive: {healthData.diskSpace.name}</p>
                    <p>Total: {healthData.diskSpace.totalSpace}</p>
                    <p>Free: {healthData.diskSpace.freeSpace}</p>
                  </div>
                )}

                {/* Environment Info */}
                {healthData.environment && (
                  <div className="bg-gray-50 p-4 rounded-lg">
                    <h2 className="font-semibold mb-2">Environment</h2>
                    <p>Machine Name: {healthData.environment.machineName}</p>
                    <p>OS: {healthData.environment.osVersion}</p>
                    <p>Framework: {healthData.environment.frameworkVersion}</p>
                    <p>Architecture: {healthData.environment.processArchitecture}</p>
                  </div>
                )}

                {/* Active Threads */}
                {healthData.activeThreads && (
                  <div className="bg-gray-50 p-4 rounded-lg">
                    <h2 className="font-semibold mb-2">Active Threads</h2>
                    <p>Thread Count: {healthData.activeThreads.threadCount}</p>
                  </div>
                )}
              </div>
            </div>
          )}
        </div>
      </div>
    </Layout>
  );
};

export default HealthCheck;
