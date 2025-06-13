namespace ExternalApiCore.Policies.Models
{
    public class ExternalDataModel
    {
        public int Id { get; set; }
        public string ExternalReference { get; set; } = string.Empty;
        public decimal RiskScore { get; set; }
        public DateTime AssessmentDate { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
