// vite.config.ts
import { defineConfig } from "file:///E:/ASafariM/ASafariM.Clients/asafarim-ui/node_modules/vite/dist/node/index.js";
import { configDefaults, defineConfig as defineVitest } from "file:///E:/ASafariM/ASafariM.Clients/asafarim-ui/node_modules/vitest/dist/config.js";
import react from "file:///E:/ASafariM/ASafariM.Clients/asafarim-ui/node_modules/@vitejs/plugin-react/dist/index.mjs";
import vitePluginMd from "file:///E:/ASafariM/ASafariM.Clients/asafarim-ui/node_modules/vite-plugin-md/dist/index.js";
import path from "path";
var __vite_injected_original_dirname = "E:\\ASafariM\\ASafariM.Clients\\asafarim-ui";
var vite_config_default = defineConfig({
  plugins: [
    react(),
    vitePluginMd({
      markdownItOptions: {
        html: true
      }
    })
  ],
  resolve: {
    alias: {
      "@": path.resolve(__vite_injected_original_dirname, "./src"),
      "@assets": path.resolve(__vite_injected_original_dirname, "src/assets"),
      "@mdfiles": path.resolve(__vite_injected_original_dirname, "../../docs")
    }
  },
  define: {
    "process.env": {
      NODE_ENV: JSON.stringify(process.env.NODE_ENV),
      VITE_API_URL: JSON.stringify("http://localhost:5000")
    }
  },
  server: {
    port: 3e3,
    open: true,
    proxy: {
      "/api": "http://localhost:5000"
      // Proxying backend API requests
    }
  },
  css: {
    postcss: "./postcss.config.cjs"
  },
  assetsInclude: ["**/*.md"],
  build: {
    outDir: "dist",
    // Relative to the yarn workspace root directory: E:\ASafariM\dist
    emptyOutDir: true,
    // Cleans the directory before build
    sourcemap: true
  }
});
var vitestConfig = defineVitest({
  test: {
    environment: "jsdom",
    globals: true,
    setupFiles: "./tests/setupTests.js",
    exclude: [...configDefaults.exclude],
    coverage: {
      reporter: ["text", "json", "html"]
    }
  }
});
export {
  vite_config_default as default,
  vitestConfig
};
//# sourceMappingURL=data:application/json;base64,ewogICJ2ZXJzaW9uIjogMywKICAic291cmNlcyI6IFsidml0ZS5jb25maWcudHMiXSwKICAic291cmNlc0NvbnRlbnQiOiBbImNvbnN0IF9fdml0ZV9pbmplY3RlZF9vcmlnaW5hbF9kaXJuYW1lID0gXCJFOlxcXFxBU2FmYXJpTVxcXFxBU2FmYXJpTS5DbGllbnRzXFxcXGFzYWZhcmltLXVpXCI7Y29uc3QgX192aXRlX2luamVjdGVkX29yaWdpbmFsX2ZpbGVuYW1lID0gXCJFOlxcXFxBU2FmYXJpTVxcXFxBU2FmYXJpTS5DbGllbnRzXFxcXGFzYWZhcmltLXVpXFxcXHZpdGUuY29uZmlnLnRzXCI7Y29uc3QgX192aXRlX2luamVjdGVkX29yaWdpbmFsX2ltcG9ydF9tZXRhX3VybCA9IFwiZmlsZTovLy9FOi9BU2FmYXJpTS9BU2FmYXJpTS5DbGllbnRzL2FzYWZhcmltLXVpL3ZpdGUuY29uZmlnLnRzXCI7aW1wb3J0IHsgZGVmaW5lQ29uZmlnIH0gZnJvbSAndml0ZSc7XG5pbXBvcnQgeyBjb25maWdEZWZhdWx0cywgZGVmaW5lQ29uZmlnIGFzIGRlZmluZVZpdGVzdCB9IGZyb20gJ3ZpdGVzdC9jb25maWcnO1xuaW1wb3J0IHJlYWN0IGZyb20gJ0B2aXRlanMvcGx1Z2luLXJlYWN0JztcbmltcG9ydCB2aXRlUGx1Z2luTWQgZnJvbSAndml0ZS1wbHVnaW4tbWQnO1xuaW1wb3J0IHBhdGggZnJvbSAncGF0aCc7XG5cbi8vIGh0dHBzOi8vdml0ZS5kZXYvY29uZmlnL1xuZXhwb3J0IGRlZmF1bHQgZGVmaW5lQ29uZmlnKHtcbiAgcGx1Z2luczogW1xuICAgIHJlYWN0KCksXG4gICAgdml0ZVBsdWdpbk1kKHtcbiAgICAgIG1hcmtkb3duSXRPcHRpb25zOiB7XG4gICAgICAgIGh0bWw6IHRydWUsXG4gICAgICB9LFxuICAgIH0pLFxuICBdLFxuICByZXNvbHZlOiB7XG4gICAgYWxpYXM6IHtcbiAgICAgICdAJzogcGF0aC5yZXNvbHZlKF9fZGlybmFtZSwgJy4vc3JjJyksXG4gICAgICAnQGFzc2V0cyc6IHBhdGgucmVzb2x2ZShfX2Rpcm5hbWUsICdzcmMvYXNzZXRzJyksXG4gICAgICAnQG1kZmlsZXMnOiBwYXRoLnJlc29sdmUoX19kaXJuYW1lLCAnLi4vLi4vZG9jcycpLFxuICAgIH0sXG4gIH0sXG4gIGRlZmluZToge1xuICAgICdwcm9jZXNzLmVudic6IHtcbiAgICAgIE5PREVfRU5WOiBKU09OLnN0cmluZ2lmeShwcm9jZXNzLmVudi5OT0RFX0VOViksXG4gICAgICBWSVRFX0FQSV9VUkw6IEpTT04uc3RyaW5naWZ5KCdodHRwOi8vbG9jYWxob3N0OjUwMDAnKSxcbiAgICB9LFxuICB9LFxuICBzZXJ2ZXI6IHtcbiAgICBwb3J0OiAzMDAwLFxuICAgIG9wZW46IHRydWUsXG4gICAgcHJveHk6IHtcbiAgICAgICcvYXBpJzogJ2h0dHA6Ly9sb2NhbGhvc3Q6NTAwMCcsIC8vIFByb3h5aW5nIGJhY2tlbmQgQVBJIHJlcXVlc3RzXG4gICAgfSxcbiAgfSxcbiAgY3NzOiB7XG4gICAgcG9zdGNzczogJy4vcG9zdGNzcy5jb25maWcuY2pzJyxcbiAgfSxcbiAgYXNzZXRzSW5jbHVkZTogWycqKi8qLm1kJ10sXG4gIGJ1aWxkOiB7XG4gICAgb3V0RGlyOiAnZGlzdCcsIC8vIFJlbGF0aXZlIHRvIHRoZSB5YXJuIHdvcmtzcGFjZSByb290IGRpcmVjdG9yeTogRTpcXEFTYWZhcmlNXFxkaXN0XG4gICAgZW1wdHlPdXREaXI6IHRydWUsIC8vIENsZWFucyB0aGUgZGlyZWN0b3J5IGJlZm9yZSBidWlsZFxuICAgIHNvdXJjZW1hcDogdHJ1ZSxcbiAgfSxcbn0pO1xuXG5leHBvcnQgY29uc3Qgdml0ZXN0Q29uZmlnID0gZGVmaW5lVml0ZXN0KHtcbiAgdGVzdDoge1xuICAgIGVudmlyb25tZW50OiAnanNkb20nLFxuICAgIGdsb2JhbHM6IHRydWUsXG4gICAgc2V0dXBGaWxlczogJy4vdGVzdHMvc2V0dXBUZXN0cy5qcycsXG4gICAgZXhjbHVkZTogWy4uLmNvbmZpZ0RlZmF1bHRzLmV4Y2x1ZGVdLFxuICAgIGNvdmVyYWdlOiB7XG4gICAgICByZXBvcnRlcjogWyd0ZXh0JywgJ2pzb24nLCAnaHRtbCddLFxuICAgIH0sXG4gIH0sXG59KTtcbiJdLAogICJtYXBwaW5ncyI6ICI7QUFBa1QsU0FBUyxvQkFBb0I7QUFDL1UsU0FBUyxnQkFBZ0IsZ0JBQWdCLG9CQUFvQjtBQUM3RCxPQUFPLFdBQVc7QUFDbEIsT0FBTyxrQkFBa0I7QUFDekIsT0FBTyxVQUFVO0FBSmpCLElBQU0sbUNBQW1DO0FBT3pDLElBQU8sc0JBQVEsYUFBYTtBQUFBLEVBQzFCLFNBQVM7QUFBQSxJQUNQLE1BQU07QUFBQSxJQUNOLGFBQWE7QUFBQSxNQUNYLG1CQUFtQjtBQUFBLFFBQ2pCLE1BQU07QUFBQSxNQUNSO0FBQUEsSUFDRixDQUFDO0FBQUEsRUFDSDtBQUFBLEVBQ0EsU0FBUztBQUFBLElBQ1AsT0FBTztBQUFBLE1BQ0wsS0FBSyxLQUFLLFFBQVEsa0NBQVcsT0FBTztBQUFBLE1BQ3BDLFdBQVcsS0FBSyxRQUFRLGtDQUFXLFlBQVk7QUFBQSxNQUMvQyxZQUFZLEtBQUssUUFBUSxrQ0FBVyxZQUFZO0FBQUEsSUFDbEQ7QUFBQSxFQUNGO0FBQUEsRUFDQSxRQUFRO0FBQUEsSUFDTixlQUFlO0FBQUEsTUFDYixVQUFVLEtBQUssVUFBVSxRQUFRLElBQUksUUFBUTtBQUFBLE1BQzdDLGNBQWMsS0FBSyxVQUFVLHVCQUF1QjtBQUFBLElBQ3REO0FBQUEsRUFDRjtBQUFBLEVBQ0EsUUFBUTtBQUFBLElBQ04sTUFBTTtBQUFBLElBQ04sTUFBTTtBQUFBLElBQ04sT0FBTztBQUFBLE1BQ0wsUUFBUTtBQUFBO0FBQUEsSUFDVjtBQUFBLEVBQ0Y7QUFBQSxFQUNBLEtBQUs7QUFBQSxJQUNILFNBQVM7QUFBQSxFQUNYO0FBQUEsRUFDQSxlQUFlLENBQUMsU0FBUztBQUFBLEVBQ3pCLE9BQU87QUFBQSxJQUNMLFFBQVE7QUFBQTtBQUFBLElBQ1IsYUFBYTtBQUFBO0FBQUEsSUFDYixXQUFXO0FBQUEsRUFDYjtBQUNGLENBQUM7QUFFTSxJQUFNLGVBQWUsYUFBYTtBQUFBLEVBQ3ZDLE1BQU07QUFBQSxJQUNKLGFBQWE7QUFBQSxJQUNiLFNBQVM7QUFBQSxJQUNULFlBQVk7QUFBQSxJQUNaLFNBQVMsQ0FBQyxHQUFHLGVBQWUsT0FBTztBQUFBLElBQ25DLFVBQVU7QUFBQSxNQUNSLFVBQVUsQ0FBQyxRQUFRLFFBQVEsTUFBTTtBQUFBLElBQ25DO0FBQUEsRUFDRjtBQUNGLENBQUM7IiwKICAibmFtZXMiOiBbXQp9Cg==
