namespace WarehouseManagement.Domain;

public class IncomingResourceDocument {
    public Guid Id { get; set; }
    public required string Number { get; set; }
    public DateTime IncomingDate { get; set; }
}
