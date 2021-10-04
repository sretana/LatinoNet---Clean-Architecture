using LatinoNet.DTOs;
using LatinoNet.Entities.Interfaces;
using LatinoNet.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinoNet.UseCases.GetAllProducts
{
    public class GetAllProductsInteractor : IGetAllProductsInputPort
    {
        readonly IProductRepository ProductRepository;
        readonly IGetAllProductsOutputPort OutputPort;

        public GetAllProductsInteractor(IProductRepository productRepository, IGetAllProductsOutputPort outputPort) =>
            (ProductRepository,OutputPort) = (productRepository, outputPort);

        public Task Handle()
        {
            var Products = ProductRepository.AllProducts().Select(p =>
            new ProductDTO
            {
                Id = p.Id,
                Name = p.Name
            });
            OutputPort.Handle(Products);
            return Task.CompletedTask;
        }
    }
}
