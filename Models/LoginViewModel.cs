﻿using System.ComponentModel.DataAnnotations;

namespace LoginRequestTemplate1.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı girin")]
        [StringLength(30, ErrorMessage = "kullanıcı adı 30 karekter olabilir en fazla")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Parola zorunludur")]
        [MinLength(6, ErrorMessage = "En az 6 karekter olmalıdır")]
        [MaxLength(16, ErrorMessage = "En fazla 16 karekter olabilir")]
        public string Password { get; set; }
    }
}
