using FluentValidation.Results;
using Net5TestApp.Common.Objects;
using System.Collections.Generic;

namespace Net5TestApp.Business.Extensions
{
    public static class ValidationResultExtension
    {
        public static List<CustomValidationError> CustomValidationErrors(this ValidationResult result)
        {
            List<CustomValidationError> customValidationErrors = new();
            foreach (var error in result.Errors)
            {
                customValidationErrors.Add(new CustomValidationError
                {
                    ErrorMessage = error.ErrorMessage,
                    PropertyName = error.PropertyName
                });
            }
            return customValidationErrors;
        }
    }
}
