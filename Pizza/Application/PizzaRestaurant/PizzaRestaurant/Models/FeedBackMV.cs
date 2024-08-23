using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzaRestaurant.Models
{
    [Table("FeedBackTable")]
    public class FeedBackMV
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FeedBackID { get; set; }
        public int UserID { get; set; }
        [MaxLength(350, ErrorMessage ="Mail is not more than 350 digits")]
        public string EmailAddress { get; set; }
        [Required]
        [MaxLength(350, ErrorMessage = "Name is not more than 350 digits")]
        public string UserName { get; set; }
        [MaxLength(500, ErrorMessage = "Message is not more than 500 digits")]
        public string FeedBack { get; set; }
    }
}