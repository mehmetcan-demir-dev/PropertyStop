﻿namespace PropertyStop_UI.Dtos.ProductDtos
{
    public class ResultLast5ProductsWithCategoryDto
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public int ProductCategory { get; set; }
        public string CategoryName { get; set; }
        public DateTime ProductDate { get; set; }
    }
}
