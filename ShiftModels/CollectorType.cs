namespace IotEdgeConfigurationApi.Models.ShiftModels
{
    public class CollectorType : LifeCycleEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}