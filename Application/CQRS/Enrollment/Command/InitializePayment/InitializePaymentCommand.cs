using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTO;
using MediatR;

namespace Application.CQRS.Payment.Command
{
    public record InitializePaymentCommand(decimal Amount) : IRequest<BaseResponse<PaymentDto>>;
}