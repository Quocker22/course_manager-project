using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Project.Areas.Admin.Models.ADO.NET;
using System.Data.SqlClient;
using System.Data; // ánh xạ DB

namespace Project.Models.EF
{
    public class Course
    {

        //[Key]
        
        public string MA_COURSE {get; set;}
        //[Required(ErrorMessage = "FULLNAME không được để trống!")]
        //[StringLength(64, ErrorMessage = "FULLNAME không vượt quá 64 kí tự!")]
        [Display(Name = "TÊN COURSE")]
        public string NAME_COURSE { get; set; }
        [Display(Name = "Mô Tả")]
        public string DESCRIPTION_COURSE { get; set; }
        [Display(Name = "GIÁ")]
        public int PRICE_COURSE { get; set; }
        [Display(Name = "Trạng Thái")]
        public string STATUS_COURSE { get; set; }
        public string THUMBNAIL { get; set; }
        public int COUNT_LESSON_COURSE { get; set; }
        public DateTime CREATED_AT_COURSE { get; set; }
        public DateTime UPDATE_AT_COURSE { get; set; }
	    public string EMAIL_COURSE {get; set;}
        public string LEVEL_COURSE { get; set; }
        public string TYPE_COURSE { get; set; }

    }
    
}