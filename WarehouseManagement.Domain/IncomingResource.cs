namespace WarehouseManagement.Domain;

public class IncomingResource {
    public Guid Id { get; set; }
    public Guid DocumentId { get; set; }
    public Guid ResourceId { get; set; }
    public Guid MeasurementUnitId { get; set; }
    public ulong Amount { get; set; }
}
