﻿using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.Custom_Exceptions
{
    public class ValidationException : ApplicationException
    {
        public List<string> Errors { get; set; } = new List<string>();

        public ValidationException(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Errors.Add(error.ErrorMessage);
            }
        }
    }
}
