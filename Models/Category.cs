using System;
using System.Collections.Generic;

namespace ProductCatalog.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        //Enumerable é sempre uma lista ou catalogo de algo, uma coleção de dados.
        public IEnumerable<Product> Products { get; set; }
    }
}