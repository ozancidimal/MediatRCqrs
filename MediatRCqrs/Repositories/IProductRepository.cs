using MediatRCqrs.Entities;

namespace MediatRCqrs.Repositories
{
    public interface IProductRepository
    {
        public Product GetProductById(int id);
        public List<Product> GetAllProducts();

        public Product Add(Product product);

        public Product Update(Product product); 

        public bool DeleteById(int id);


    }
}
