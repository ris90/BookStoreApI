using MongoDB.Bson.Serialization.Attributes;

namespace StudentProfileApi.Models
{
    public class Student
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id{ get; set; }
        public int Roll { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Class { get; set; }
        public string Group { get; set; }
    }
}
