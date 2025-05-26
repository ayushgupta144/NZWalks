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
        /// Name Ayush
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ImageURL img
        /// </summary>
        public string? RegionImageUrl { get; set; }
    }
}
