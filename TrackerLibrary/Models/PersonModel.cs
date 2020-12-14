namespace TrackerLibrary.Models
{
    /// <summary>
    /// represents one person
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// unique identifier for the prize
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// the first name of the person
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// the last name of the person
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// primary email address of the person
        /// </summary>
        public string EmailAdress { get; set; }
        /// <summary>
        /// primary phone of the person
        /// </summary>
        public string PhoneNumber { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
