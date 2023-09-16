using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBCRUD.Models
{
    public class GiaHanEntity
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }
        public string TENDG { get; set; }
        public string TENSACH { get; set; }
        public string TUNGAY { get; set; }
        public string DENNGAY { get; set; }
        
    }
}
