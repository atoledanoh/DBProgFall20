using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// represents one person
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// the first name of the person
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// the last name of the person
        /// </summary>
        public string Lastname { get; set; }
        /// <summary>
        /// primary email address of the person
        /// </summary>
        public string EmailAdress { get; set; }
        /// <summary>
        /// primary phone of the person
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
