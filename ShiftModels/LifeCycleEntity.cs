using System;

namespace IotEdgeConfigurationApi.Models.ShiftModels
{
    public class LifeCycleEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public bool IsDeleted { get { return DeletedAt != null; } }

        public LifeCycleEntity()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
    }
}
