using System.ComponentModel.DataAnnotations;

namespace Ciocmarean_Cristian_Laborator2.Models
{
    public class Authors
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Display (Name = "Full Name")]
        public String FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public ICollection<Book>? Books { get; set; }
    }
}
