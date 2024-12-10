using System;

namespace PropertyStop.Dtos.ProductDetailDtos
{
    public class GetProductDetailByIDDto
    {
        public int ProductDetailID { get; set; }
        public int ProductSize { get; set; }
        public int BedRoomCount { get; set; }
        public int BathCount { get; set; }
        public int GarageSize { get; set; }
        public string BuildYear { get; set; }
        public decimal Price { get; set; }
        public string Location { get; set; }
        public string VideoUrl { get; set; }
        public int ProductID { get; set; }

        public DateTime ProductDate { get; set; }
    }
}
