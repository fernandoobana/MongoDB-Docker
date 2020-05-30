using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TesteMongoDocker
{
    public class ObjTeste
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }
    }
}
