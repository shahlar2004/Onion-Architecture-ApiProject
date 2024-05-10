using ApiProject.Application.Interfaces.UnitOfWorks;
using ApiProject.Domain.Entities;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Application.Features.Products.Command.UpdateProduct
{
    public class UpdateUpdateCommandHandler : IRequestHandler<UpdateProductCommandRequest,Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

      
        public UpdateUpdateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {

            var product = await unitOfWork.GetReadRepoitory<Product>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            var map = mapper.Map<Product>(request);
            var productCategories = await unitOfWork.GetReadRepoitory<ProductCategory>().GetAllAsync(x => x.ProductId == product.Id);
            await unitOfWork.GetWriteRepostitory<ProductCategory>().HardRangeDeleteAsync(productCategories);

            foreach (var categoryId in request.CategoryList)
                await unitOfWork.GetWriteRepostitory<ProductCategory>().AddAsync(new()
                {
                    CategoryId = categoryId,
                    ProductId = product.Id,
                });

            await unitOfWork.GetWriteRepostitory<Product>().UpdateAsync(map);
            await unitOfWork.SaveAsync();

            return Unit.Value;

        }

        //Task IRequestHandler<UpdateProductCommandRequest>.Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
