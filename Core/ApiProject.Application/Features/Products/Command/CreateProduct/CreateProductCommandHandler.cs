using ApiProject.Application.Bases;
using ApiProject.Application.Features.Products.Rules;
using ApiProject.Application.Interfaces.UnitOfWorks;
using ApiProject.Domain.Entities;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Application.Features.Products.Command.CreateProduct
{
    public class CreateProductCommandHandler :BaseHandler, IRequestHandler<CreateProductCommandRequest,Unit>
    {
        private readonly ProductRules productRules;

        public CreateProductCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, ProductRules productRule) :base(mapper,unitOfWork,httpContextAccessor)
        {
            this.productRules = productRule;
        }

    
        public async Task<Unit> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            Product product = new(request.Title, request.Description, request.BrandId, request.Price, request.Discount);

            IList<Product> products = await unitOfWork.GetReadRepoitory<Product>().GetAllAsync();

            productRules.ProductTitleMustNotBeSame(products,request.Title);

            await unitOfWork.GetWriteRepostitory<Product>().AddAsync(product);

            if (await unitOfWork.SaveAsync() > 0)
            {
                foreach (var item in request.CategoryList)
                {
                    await unitOfWork.GetWriteRepostitory<ProductCategory>().AddAsync(new ProductCategory
                    {
                        ProductId = product.Id,
                        CategoryId = item
                    });
                }

                await unitOfWork.SaveAsync();
            }

            return Unit.Value;


        }
    }
}
