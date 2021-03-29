namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// The unique identifer of person
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents first name of person
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Represents last name of person
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Represents fEmail Address of person
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Represents cellphone number of person
        /// </summary>
        public string CellphoneNumber { get; set; }

       

        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }"; 
            }
        
        }

    }
}
