using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBCRUD.Models
{
    public class BookEntity
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { set; get; }
        public string MASACH { set; get; }
        public string TENSACH { set; get; }
        public string THELOAI { set; get; }
        public string TACGIA { set; get; }
        public string NGAYXB { set; get; }
        public int SOLUONG { set; get; }
    }
}
