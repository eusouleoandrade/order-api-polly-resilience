using AutoMapper;
using OAPR.Application.Dtos.Requests;
using OAPR.Domain.Entities;

namespace OAPR.Application.Mappers
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<OrderUpdateUseCaseRequest, Order>();

            CreateMap<OrderUpdateRequest, OrderUpdateUseCaseRequest>();
        }
    }
}