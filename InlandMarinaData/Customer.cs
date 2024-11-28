using System.ComponentModel.DataAnnotations;

namespace InlandMarinaData
{
    public class Customer
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        [Display (Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(15)]
        public string Phone { get; set; }

        [Required]
        [StringLength(30)]
        public string City { get; set; }

        // navigation property
        public virtual ICollection<Lease> Leases { get; set; }
    }
}
