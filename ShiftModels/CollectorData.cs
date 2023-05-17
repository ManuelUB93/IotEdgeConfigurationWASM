using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace IotEdgeConfigurationApi.Models.ShiftModels
{
    public class CollectorData : LifeCycleEntity
    {
        public int Id { get; set; }
        public int CollectorId { get; set; }
        public Collector? Collector { get; set; }
        public string? ValueString { get; set; }
        public bool? ValueBool { get; set; }
        public Double? ValueDouble { get; set; }
    }
}