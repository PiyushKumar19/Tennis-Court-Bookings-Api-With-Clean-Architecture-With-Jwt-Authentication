using TennisCourtBookings.Application.Features.UserFeatures.CreateUser;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtBookings.Application.Features.CourtBookingsFeatures.DeleteCourtBookings
{
    public sealed class DeleteCourtBookingsValidator : AbstractValidator<DeleteCourtBookingsRequest>
    {
        public DeleteCourtBookingsValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
