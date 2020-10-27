using InvoiceManagementBlazor.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InvoiceManagementBlazor.Shared.Entities
{
    public class User : IBaseEntity<Guid>
    {
        public User()
        {
            CreatedDate = DateTime.Now;
        }
        public Guid Id { get; set; }
        [Required(ErrorMessage =("نام کاربری الزامی است"))]
        public string  UserName { get; set; }
        [Required(ErrorMessage = ("رمز الزامی است"))]
        public string  Password { get; set; }
        [Required(ErrorMessage = ("نام  الزامی است"))]
        public string  FullName { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
