namespace ExternalApiCore.Policies.DTOs
{
    public class ValidationResultDto
    {
        /// <summary>
        /// Indicates whether the validation was successful.
        /// </summary>
        public bool IsValid { get; set; }
        /// <summary>
        /// A message providing additional information about the validation result.
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// A code identifying the validation result.
        /// </summary>
        public string ValidationCode { get; set; } = string.Empty;
    }
}
