﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Viddz.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown || 
                customer.MembershipTypeId == MembershipType.PayAsYouGo)
            {
                return ValidationResult.Success;
            }
            if (customer.Birthday == null)
            {
                return new ValidationResult("Birthday is required");
            }
            var age = DateTime.Today.Year - customer.Birthday.Value.Year;

            if (age>=18)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Customer should be at least 18 years old get a membership");
            }

        }
    }
}