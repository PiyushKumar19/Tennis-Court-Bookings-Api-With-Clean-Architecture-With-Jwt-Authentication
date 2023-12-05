using TennisCourtBookings.Application.Features.UserFeatures.CreateUser;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtBookings.Application.Features.TennisCourtFeatures.UpdateTennisCourt
{
    public sealed class UpdateTennisCourtValidator : AbstractValidator<UpdateTennisCourtRequest>
    {
        public UpdateTennisCourtValidator()
        {
            RuleFor(x => x.Address).NotEmpty().MaximumLength(50);
            RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
        }
    }
}
