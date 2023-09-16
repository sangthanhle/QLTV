using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBCRUD.Models
{
    public class Muon_Tra_Entity
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }
        public string TENDG { get; set; }
        public string TENSACH { get; set; }
        public int SL { get; set; }
        public string NGMUON { get; set; }
        public string NGQDTRA { get; set; }
        public string NGTRA { get; set; }
        public int PHATQH { get; set; }

    }
}
