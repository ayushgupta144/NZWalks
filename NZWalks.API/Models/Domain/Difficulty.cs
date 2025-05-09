namespace NZWalks.API.Models.Domain
{
    /// <summary>
    /// Represents the difficulty level of a walk. 
    /// </summary>
    public class Difficulty
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
