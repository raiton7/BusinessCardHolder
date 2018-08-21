namespace BusinessCardHolder.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(200)]
        public string JobTitle { get; set; }

        [Required]
        [StringLength(16)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(16)]
        public string MobilePhoneNumber { get; set; }

        public virtual Company Company { get; set; }

        [NotMapped]
        public string CompanyName
        {
            get
            {
                if (Company != null)
                    return Company.Name;
                else
                    return string.Empty;
            }
        }
    }
}
