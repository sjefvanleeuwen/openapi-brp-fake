using System.Xml.Linq;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
using App.Metrics.AspNetCore;
using App.Metrics;
using App.Metrics.Formatters.Prometheus;
namespace Org.OpenAPITools
{
    /// <summary>
    /// Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        /// <summary>
        /// Build Web Host
        /// </summary>
        /// <param name="args"></param>
        /// <returns>Webhost</returns>
        public static IWebHost BuildWebHost(string[] args)
        {

            var Metrics = AppMetrics.CreateDefaultBuilder()
                .OutputMetrics.AsPrometheusPlainText()
                .OutputMetrics.AsPrometheusProtobuf()
            .Build();
            System.Diagnostics.Debug.WriteLine(Metrics.DefaultOutputMetricsFormatter.MediaType.GetType());

            return WebHost.CreateDefaultBuilder(args)
                        .ConfigureMetrics(Metrics)
                        .UseMetrics(
                            options =>
                            {
                                options.EndpointOptions = endpointsOptions =>
                                {
                                  endpointsOptions.MetricsTextEndpointOutputFormatter = Metrics.OutputMetricsFormatters.ElementAt(2);
                               };
                            })
                        .UseStartup<Startup>()
                        .UseUrls("http://0.0.0.0:5080/")
                        .Build();
        }
    }
}
