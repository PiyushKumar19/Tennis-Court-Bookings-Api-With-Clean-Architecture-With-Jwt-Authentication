using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisCourtBookings.Application.Features.UserFeatures.UpdateUser;

namespace TennisCourtBookings.Application.Features.UserFeatures.RegisterUser
{
    public sealed class UpdateUserValidator : AbstractValidator<RegisterUserRequest>
    {
        public UpdateUserValidator()
        {
            RuleFor(x => x.Email).NotEmpty().MaximumLength(50).EmailAddress();
            RuleFor(x => x.Password).NotEmpty().MinimumLength(3).MaximumLength(20);
        }
    }
}
