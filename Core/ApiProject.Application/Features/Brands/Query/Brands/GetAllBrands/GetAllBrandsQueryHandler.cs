using ApiProject.Application.Interfaces.UnitOfWorks;
using ApiProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Application.Features.Brands.Query.Brands.GetAllBrands
{
    public class GetAllBrandsQueryHandler : IRequestHandler<GetAllBrandsQueryRequest, IList<GetAllBrandsQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMediator mediator;

        public GetAllBrandsQueryHandler(IUnitOfWork unitOfWork, IMediator mediator)
        {
            this.unitOfWork = unitOfWork;
            this.mediator = mediator;
        }
        public async Task<IList<GetAllBrandsQueryResponse>> Handle(GetAllBrandsQueryRequest request, CancellationToken cancellationToken)
        {
            var brands = await unitOfWork.GetReadRepoitory<Brand>().GetAllAsync();

            List<GetAllBrandsQueryResponse> responses = new();

            foreach (var brand in brands)
            {
                responses.Add(new GetAllBrandsQueryResponse()
                {
                    Name = brand.Name
                });
            }

            return responses;
        }
    }
}
