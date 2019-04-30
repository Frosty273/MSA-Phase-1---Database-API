using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace schoolSIMS.Model
{
    [Table("students")]
    public partial class Students
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("first_name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Column("last_name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Column("phone_name")]
        [StringLength(20)]
        public string PhoneName { get; set; }
        [Column("email")]
        [StringLength(50)]
        public string Email { get; set; }
        [Column("house_address")]
        [StringLength(50)]
        public string HouseAddress { get; set; }
        [Column("gender")]
        [StringLength(5)]
        public string Gender { get; set; }
        [Column("dob", TypeName = "date")]
        public DateTime? Dob { get; set; }
        [Column("date_created", TypeName = "date")]
        public DateTime? DateCreated { get; set; }
    }
}
