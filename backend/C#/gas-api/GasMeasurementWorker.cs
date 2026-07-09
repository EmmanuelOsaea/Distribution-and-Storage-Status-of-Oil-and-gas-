using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace 
GasApi.Services
    {
public class
  GasMeasurementWorker:
BackgroundService
   {
     protected override async Task
 ExecuteAsync(CancellationToken
 stoppingToken)
     {

client or modbus connection here

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
