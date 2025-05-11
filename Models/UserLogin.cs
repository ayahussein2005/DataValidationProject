using System.ComponentModel.DataAnnotations;

namespace DataValidationProject.Models
{
    public class UserLogin
    {
        /*حددنا الاسم الي بدو يظهر في UI
         عملنا ايرور مسج انو الحقل م يكون فاضي 
        عملنا حد للاسم من3 ل 50 واذا تجاوز الحد بيطلع ايرور مسج*/
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 50 characters")]
        public string Username { get; set; }

        /* الحقل ما يكون فاضي
        نوع الداتا كلمة سر
        حد لكلمة لسر من 6 ل 100 وايرور مسج*/
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters")]
        public string Password { get; set; }
        /*bool هل المستخدم يريد حفظ معلومات تسجيل الدخول او لأ*/
        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
