using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // ánh xạ DB
namespace Project.Models.EF
{
    [Table("ORDER_COURSE")]
    public class ORDER_COURSE
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public string MA_ORDER {get; set;}
	    public string MA_COURSE {get; set;}
	    public string MA_USER  {get; set;}
        [Required(ErrorMessage = "NAME không được để trống!")]
        [StringLength(64, ErrorMessage = "NAME không vượt quá 64 kí tự!")]
	    public string FULLNAME_USER {get; set;}
	    public string STATUS_ORDER {get; set;}
	    public DateTime CREATED_AT_ORDER {get; set;}
        public DateTime UPDATE_AT_ORDER { get; set; }
    }
}