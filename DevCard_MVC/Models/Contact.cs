using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [MinLength(3,ErrorMessage = "حداقل باید 3  کاراکتر باشد")]
        [MaxLength(100,ErrorMessage = "حداکثر 100 کاراکتر باید باشد")]
        public String Name { get; set; }

        [EmailAddress(ErrorMessage = "ایمیل را صحیح وارد کنید")]
        [Required(ErrorMessage = "این فیلد اجباری است")]

        public String Email { get; set; }
        public String Message { get; set; }
        public String Service { get; set; }

    }
}
