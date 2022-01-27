using AutoMapper;
using Centric.eCommerce.Product.Api.DB;
using Centric.eCommerce.Product.Api.Interfaces;

namespace Centric.eCommerce.Product.Api.Providers;

public class ProductProvider : IProductProvider
{
    private readonly ProductDbContext context;
    private readonly ILogger<ProductProvider> logger;
    private readonly IMapper mapper;

    public ProductProvider(ProductDbContext context, ILogger<ProductProvider> logger, IMapper mapper)
    {
        this.context = context;
        this.logger = logger;
        this.mapper = mapper;
    }
}