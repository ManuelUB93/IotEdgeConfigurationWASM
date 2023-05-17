using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace IotEdgeConfigurationApi.Models.ShiftModels
{
    public class Collector : LifeCycleEntity
    {
        public int Id { get; set; }
        public int? MachineId { get; set; }
        public Machine? Machine { get; set; }
        public int FPHardwareId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string RemoteAddress { get; set; }
        public string SerialNumber { get; set; }
        public int InputIndex { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? InstallDate { get; set; }
        public bool IsOnline { get; set; }
        public CollectorType Type { get; set; }
        public int TypeId { get; set; }
        public string? Tag { get; set; }
        public virtual ICollection<CollectorData> CollectorData { get; set; }
        public Collector()
        {
            CollectorData = new List<CollectorData>();
        }
    }
}