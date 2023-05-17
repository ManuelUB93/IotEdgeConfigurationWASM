using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace IotEdgeConfigurationApi.Models.ShiftModels
{
    public class Machine : LifeCycleEntity
    {
        public int Id { get; set; }
        public int? FactoryId { get; set; }
        public virtual Factory? Factory { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Group { get; set; }
        public string? Tag { get; set; }
        public string? RemoteAddress { get; set; }
        public virtual ICollection<Collector> Collectors { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }
        public Machine()
        {
            Collectors = new List<Collector>();
            Attachments = new List<Attachment>();
        }
    }
}