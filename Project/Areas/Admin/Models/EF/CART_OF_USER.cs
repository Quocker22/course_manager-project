using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // ánh xạ DB
namespace Project.Models.EF
{
    [Table("CART_OF_USER")]
    public class CART_OF_USER
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public string MA_USER {get; set;}
        public string MA_COURSE { get; set; }
    }
}