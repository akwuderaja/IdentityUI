﻿using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace SSRD.IdentityUI.Core.Helper
{
    public class AbstractValidatorWithNullCheck<T> : AbstractValidator<T>
    {
        protected override bool PreValidate(ValidationContext<T> context, ValidationResult result)
        {
            if (context.InstanceToValidate == null)
            {
                result.Errors.Add(new ValidationFailure("", "Model can not be null"));
                return false;
            }

            return base.PreValidate(context, result);
        }
    }
}
