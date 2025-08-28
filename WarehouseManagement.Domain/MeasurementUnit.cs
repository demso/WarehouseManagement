namespace WarehouseManagement.Domain;

public class MeasurementUnit {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public WorkingState State { get; set; }
}
