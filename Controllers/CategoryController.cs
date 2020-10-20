using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCatalog.Data;
using ProductCatalog.Models;
namespace Controllers
{
    public class CategoryController : Controller
    {
        private readonly StoreDataContext _context;

        public CategoryController(StoreDataContext context)
        {
            _context = context;
        }

        [Route("v1/categories")]
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            //AsNoTracking = utilizado para não ficar trazendo informações extras das entidades
            //Otimiza a aplicação para que não haja retorno de informações redundantes
            return _context.Categories.AsNoTracking().ToList();
        }        

        [Route("v1/categories/{id}")]
        [HttpGet]
        public Category Get(int id)
        {
            //Find() ainda não suporta AsNoTracking
            //First Or Default = Pega o primeiro item do where, caso não haja, é retornado nulo
            return _context.Categories.AsNoTracking().Where(x => x.Id == id).FirstOrDefault();
        }

        //Listando produtos de uma categoria
        [Route("v1/categories/{id}/products")]
        [HttpGet]
        public IEnumerable<Product> GetProducts(int id)
        {
            //
            return _context.Products.AsNoTracking().Where(x => x.CategoryId == id).ToList();
        }

        [Route("v1/categories")]
        [HttpPost]
        public Category Post([FromBody] Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }
        
        [Route("v1/categories")]
        [HttpPut]
        public Category Put([FromBody] Category category)
        {
            _context.Entry<Category>(category).State = EntityState.Modified;
            _context.SaveChanges();
            return category;
        }

        [Route("v1/categories")]
        [HttpDelete]
        public Category Delete([FromBody] Category category)
        {
            _context.Categories.Remove(category);
            return category;
        }

    }
}