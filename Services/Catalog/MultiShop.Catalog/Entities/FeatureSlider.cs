using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MultiShop.Catalog.Entities
{
    public class FeatureSlider
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string FeatureSliderId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string İmageUrl { get; set; }
        public bool status { get; set; }


    }
}
