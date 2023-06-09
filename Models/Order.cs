﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SmallShopIT.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        [Required(ErrorMessage = "Proszę podać swoje imię")]
        [Display(Name = "Imię")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Proszę podać swoje nazwisko")]
        [Display(Name = "Nazwisko")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Proszę podać swój adres")]
        [StringLength(100)]
        [Display(Name = "Adres")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Adres cd.")]
        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "Proszę podać kod pocztowy")]
        [Display(Name = "Kod pocztowy")]
        [StringLength(10, MinimumLength = 4)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Proszę podać swoje miasto")]
        [Display(Name = "Miasto")]
        [StringLength(50)]
        public string City { get; set; }
        [StringLength(50)]
        [Display(Name = "Województwo")]
        public string State { get; set; }

        [Required(ErrorMessage = "Proszę podać kraj")]
        [Display(Name = "Kraj")]
        [StringLength(50)]
        public string Country { get; set; }

        [Required(ErrorMessage = "Proszę podać numer telefonu")]
        [Display(Name = "Telefon")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "Podany adres email jest nieprawidłowy")]
        public string Email { get; set; }
        [StringLength(1000)]
        public string PayPalReference { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }
    }
}
