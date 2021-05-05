namespace RRModels
{
    public class Review
    {
        /// <summary>
        /// Describes the overall rating of the resturant
        /// </summary>
        /// <value></value>
        public int Rating { get; set; }

        /// <summary>
        /// Describes the overall dining experience
        /// </summary>
        /// <value></value>
        public string Description { get; set; }

        public override string ToString()
        {
            return $" Rating: {Rating} \n\t Description: {Description}";
        }
    }
}