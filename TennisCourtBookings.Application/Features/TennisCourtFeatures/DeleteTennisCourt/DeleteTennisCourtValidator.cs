using TennisCourtBookings.Application.Features.UserFeatures.CreateUser;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisCourtBookings.Application.Features.TennisCourtFeatures.DeleteTennisCourt
{
    public sealed class DeleteTennisCourtValidator : AbstractValidator<DeleteTennisCourtRequest>
    {
        public DeleteTennisCourtValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
