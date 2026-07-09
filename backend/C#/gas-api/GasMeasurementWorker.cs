using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace 
DistributionAndStorageStatusChecker.GasApi.Services
    {
public class
  GasMeasurementWorker:
BackgroundService
   {
     protected override async Task
 ExecuteAsync(CancellationToken
 stoppingToken)
     {

     while(!
stoppingToken.IsCancellationReque
sted)
   {



        await Task.Delay(5000,
stoppingToken);
seconds
 }
 }
 }
}
