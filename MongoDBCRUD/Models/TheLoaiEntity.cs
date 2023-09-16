using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBCRUD.Models
{
    public class TheLoaiEntity
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { set; get; }
        public string MATHELOAI { set; get; }
        public string TENTHELOAI { set; get; }
    }
}
