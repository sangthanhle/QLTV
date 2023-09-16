using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBCRUD.Models
{
    public class ReaderEntity
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { set; get; }
        public string MADG { set; get; }
        public string TENDG { set; get; }
        public string DCHI { set; get; }
        public string NGSINH { set; get; }
        public string SODT { set; get; }
        public string NGDK { set; get; }
    }
}

