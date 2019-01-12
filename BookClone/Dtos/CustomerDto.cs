using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using BookClone.Models;

namespace BookClone.Dtos
{
    public class CustomerDto
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(259)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }

     //   [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

    }
}