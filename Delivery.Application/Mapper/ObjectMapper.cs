using AutoMapper;
using Delivery.Core.Entities;
using Delivery.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Application.Mapper
{
    public class ObjectMapper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                // This line ensures that internal properties are also mapped over.
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<DeliveryDtoMapper>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });
        public static IMapper Mapper => Lazy.Value;

        public class DeliveryDtoMapper : Profile
        {
            public DeliveryDtoMapper()
            {
                CreateMap<Product, ProductModel>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name)).ReverseMap();

                CreateMap<Category, CategoryModel>().ReverseMap();
                CreateMap<Order, OrderModel>().ReverseMap();
                CreateMap<Cart, CartModel>().ReverseMap();
                CreateMap<CartItem, CartItemModel>().ReverseMap();
            }
        }
    }
}
