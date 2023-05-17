using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Reflection.Metadata;

namespace IotEdgeConfigurationApi.Models.ShiftModels
{
    public class Factory : LifeCycleEntity
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? DefaultLayout { get; set; }
        public string? Group { get; set; }
        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }      
        public bool IsActive { get; set; }
        public int? MinimumActivityFilter { get; set; }
        public int? MinimumInactivityFilter { get; set; }
        public int? MinimumActivityModifier { get; set; }
        public int? MaximumActivityModifier { get; set; }
        public string? FactoryKey { get; set; }
        public int? fp_core_Id { get; set; }
        public int FP_Id => fp_core_Id!.Value;
        public virtual ICollection<Machine> Machines { get; set; }
        public virtual ICollection<ApiKey> ApiKeys { get; set; }

        public Factory()
        {
            Machines = new List<Machine>();
        }
    }
}