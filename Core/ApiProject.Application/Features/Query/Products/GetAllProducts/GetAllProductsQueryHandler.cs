using ApiProject.Application.Interfaces.AutoMapper;
using ApiProject.Application.DTOs;
using ApiProject.Application.Interfaces.UnitOfWorks;
using ApiProject.Domain.Entities;
//using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Application.Features.Query.Products.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IList<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await unitOfWork.GetReadRepoitory<Product>().GetAllAsync(include: x => x.Include(b => b.Brand));
           //var map = mapper.Map<List<GetAllProductsQueryResponse>>(products);




            List<GetAllProductsQueryResponse> response = new();


            foreach (var product in products)
            {
                response.Add(new GetAllProductsQueryResponse
                {
                    Title = product.Title,
                    Description = product.Description,
                    Price = product.Price - (product.Price * product.Discount / 100),
                    Discount = product.Discount,
                    Brand=product.Brand.Name
                });

            }
                return response;
        }
    }
}