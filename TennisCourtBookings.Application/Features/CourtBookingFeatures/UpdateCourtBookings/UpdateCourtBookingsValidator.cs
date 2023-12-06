using TennisCourtBookings.Application.Features.UserFeatures.CreateUser;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtBookings.Application.Features.CourtBookingsFeatures.UpdateCourtBookings
{
    public sealed class UpdateCourtBookingsValidator : AbstractValidator<UpdateCourtBookingsRequest>
    {
        public UpdateCourtBookingsValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.CourtName).NotEmpty().MinimumLength(3).MaximumLength(50);
        }
    }
}
