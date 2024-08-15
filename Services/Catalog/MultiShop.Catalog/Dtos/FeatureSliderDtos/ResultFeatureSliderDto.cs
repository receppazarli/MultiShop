using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MultiShop.Catalog.Dtos.FeatureSliderDtos
{
    public class ResultFeatureSliderDto
    {
        public string FeatureSliderId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string İmageUrl { get; set; }
        public bool status { get; set; }
    }
}
