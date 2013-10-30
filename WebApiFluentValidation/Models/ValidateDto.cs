using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FluentValidation;
using WebApiFluentValidation.Extensions;
using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;

namespace WebApiFluentValidation.Models
{
    public class ValidateDto<T> : IValidatableObject
    {
        protected IValidator<T> validator;

        public ValidateDto(IValidator<T> validator = null)
        {
            //Todo: register in ioc 
            this.validator = validator;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            return this.validator.Validate(this).ToValidationResult();
        }
    }
}