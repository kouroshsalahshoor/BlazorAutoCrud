using BlazorAutoCrud.Data;
using Microsoft.EntityFrameworkCore;
using Shared.IRepositories;
using Shared.Models;

namespace BlazorAutoCrud.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<List<Product>> Get()
        {
            return await _db.Products.ToListAsync();
        }

        public async Task<Product?> Get(int id)
        {
            var model = await _db.Products.FirstOrDefaultAsync(x=>x.Id == id);
            if (model == null) { return null; }
            return model;
        }
        public async Task<Product?> Add(Product model)
        {
            if (model == null) return null;
            var entityEntry = await _db.Products.AddAsync(model);
            await _db.SaveChangesAsync();
            return entityEntry.Entity;
        }
        public async Task<Product?> Update(Product model)
        {
            if (model == null) return null;
            var entity = await _db.Products.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (entity == null) { return null; }
            entity.Name = model.Name;
            entity.Quantity = model.Quantity;
            var entityEntry = _db.Products.Update(entity);
            await _db.SaveChangesAsync();
            return entityEntry.Entity;
        }
        public async Task<Product?> Delete(int id)
        {
            var model = await _db.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (model is not null)
            {
                var entityEntry = _db.Products.Remove(model);
                await _db.SaveChangesAsync();
                return entityEntry.Entity;
            }
            return null;
        }
    }
}
