using MediatRCqrs.Entities;

namespace MediatRCqrs.Repositories
{
    public class ProductRepository : IProductRepository
    {
        List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>()
            {
                new Product{ Id=1, Name="ozan"},
                new Product{ Id=2, Name="mehmet"},
                new Product{ Id=3, Name="ali"},
                new Product{ Id=4, Name="ayse"},
            };
        }
        public Product Add(Product product)
        {

            _products.Add(product);
            var insertedProduct = GetProductById(product.Id);
            return insertedProduct;
        }

        public bool DeleteById(int id)
        {
            var product = GetProductById(id);

            if (product == null)
                return false;
            _products.Remove(product);
            return true;
        }

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetProductById(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public Product Update(Product product)
        {
            var productEntity = GetProductById(product.Id);
            if (productEntity != null)
            {
                productEntity.Id = product.Id;
                productEntity.Name = product.Name;
            }
            return productEntity;
        }
    }
}
