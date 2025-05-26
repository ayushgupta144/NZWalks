namespace NZWalks.API.Models.DTO
{
    /// <summary>
    /// Region DTO
    /// </summary>
    public class AddRegionRequestDto
    {
        /// <summary>
        /// Code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Ayush Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Image URL img
        /// </summary>
        public string? RegionImageUrl { get; set; }
    }
}
