namespace OilGasApi.Models;

public class StorageTank
{
  public int id { get; set; }
  public string TankName { get; set; } = string.Empty;
  public double CurrentCapacity { get; set; }
  public double MaxCapacity { get; set; }
  public string Status { get; set; } =
   "Stable"; 
}
