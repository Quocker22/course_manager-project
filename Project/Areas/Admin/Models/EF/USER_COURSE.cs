using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // ánh xạ DB
namespace Project.Models.EF
{
    [Table("USER_COURSE")]
    public class USER_COURSE
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public string MA_USER {get; set;}

        [Required(ErrorMessage= "Tên không được để trống!")]
        [StringLength(150,ErrorMessage="Tên không vượt quá 150 kí tự!")]
	    public string FULLNAME_USER {get; set;}

	    public int NUMBER_OF_USER {get; set;}
        [Required(ErrorMessage = "EMAIL không được để trống!")]
        [StringLength(150, ErrorMessage = "EMAIL không vượt quá 150 kí tự!")]
	    public string EMAIL_USER {get; set;}
        [Required(ErrorMessage = "PHONE không được để trống!")]
        [StringLength(20, ErrorMessage = "PHONE không vượt quá 20 kí tự!")]
        public string PHONE_USER {get; set;}
        public string ROLE_USER {get; set;}
        public string STATUS_USER {get; set;}
        public DateTime CREATED_AT_USER {get; set;}
        public DateTime UPDATE_AT_USER { get; set; }


    }
}