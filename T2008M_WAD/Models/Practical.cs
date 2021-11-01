
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace T2008M_WAD.Models
{
    public class Practical
    {
        [Required(ErrorMessage = "Vui lòng nhập môn học")]
        public string Subjects { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thời gian bắt đầu thi")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan? Start { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập ngày thi")]
        [DataType(DataType.Date)]
        public DateTime ExamDate { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thời gian thi")]
        public int Duration { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên lớp")]
        public string ClassRoom { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên thí sinh")]
        public string Faculty { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập trạng thái")]
        public string Status { get; set; }
    }
}