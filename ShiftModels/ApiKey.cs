using System.ComponentModel.DataAnnotations.Schema;

namespace IotEdgeConfigurationApi.Models.ShiftModels
{
    public class ApiKey 
    {
        public int Id { get; set; }
        public string KeyValue { get; set; }
        public ApiTokenType TokenType { get; set; }
        public virtual Company? Company { get; set; }
        [ForeignKey("Company")]
        public int? CompanyId { get; set; }
        public virtual Factory? Factory { get; set; }
        [ForeignKey("Factory")]
        public int? FactoryId { get; set; }
        public bool IsActive { get; set; }
        public int? fp_core_id { get; set; }
        public string ApiPrefix
        {
            get
            {
                switch (TokenType)
                {
                    case ApiTokenType.Aggregator:
                        return "CM2";
                    case ApiTokenType.PublicApi:
                    case ApiTokenType.PublicApiPost:
                        return "API";
                    case ApiTokenType.FreePointConnect:
                        return "FPC";
                }
                return "";
            }
        }
    }
    public enum ApiTokenType
    {
        Aggregator = 1, PublicApi = 2, PublicApiPost = 3, FreePointConnect = 4,
    }
}