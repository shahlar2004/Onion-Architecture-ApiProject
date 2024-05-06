using ApiProject.Application.Interfaces.UnitOfWorks;
using ApiProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Application.Features.Command.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest,Unit>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreateProductCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            Product product = new(request.Title,request.Description,request.BrandId,request.Price,request.Discount);
             await unitOfWork.GetWriteRepostitory<Product>().AddAsync(product);

            if (await unitOfWork.SaveAsync() > 0)
            {
                foreach (var item in request.CategoryList)
                {
                    await unitOfWork.GetWriteRepostitory<ProductCategory>().AddAsync(new ProductCategory
                    {
                        ProductId = product.Id,
                        CategoryId=item
                    });
                }

                await unitOfWork.SaveAsync();
            }

            return Unit.Value;


        }
    }
}
