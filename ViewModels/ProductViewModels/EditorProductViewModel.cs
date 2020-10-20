namespace ProductCatalog.ViewModels.ProductViewModels
{
    public class EditorProductViewModel
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }

        
        
    }
}