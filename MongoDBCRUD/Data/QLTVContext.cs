using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDBCRUD.Interface;
using MongoDBCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBCRUD.Data
{
    public class QLTVContext : IQLTV
    {
         
        public readonly IMongoDatabase _db;

        public QLTVContext(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.connecttionString);
            _db = client.GetDatabase(options.Value.Database);
        }
        //book
        public IMongoCollection<BookEntity> bookCollection => 
           _db.GetCollection<BookEntity>("book");

        public IEnumerable<BookEntity> GetAllBook()
        {
            return bookCollection.Find(a=>true).ToList();
        }

        public BookEntity GetBookDetails(string name)
        {
            var bookdetails = bookCollection.Find(m => m.TENSACH == name).FirstOrDefault();
            return bookdetails;
        }
        public void Create(BookEntity bookData)
        {
            bookCollection.InsertOne(bookData);
        }
        public void Update(string _id, BookEntity bookData)
        {
            var filter = Builders<BookEntity>.Filter.Eq(c => c._id, _id);
            var update = Builders<BookEntity>.Update
                .Set("MASACH", bookData.MASACH)
                .Set("TENSACH", bookData.TENSACH)
                .Set("THELOAI", bookData.THELOAI)
                .Set("TACGIA", bookData.TACGIA)
                .Set("NGAYXB", bookData.NGAYXB)
                .Set("SOLUONG", bookData.SOLUONG);
            bookCollection.UpdateOne(filter, update);
        }
        public void Delete(string Name)
        {
            var filter = Builders<BookEntity>.Filter.Eq(c => c.TENSACH, Name);
            bookCollection.DeleteOne(filter);
        }
        //GiaHan
        public IMongoCollection<GiaHanEntity> giahanCollection =>
           _db.GetCollection<GiaHanEntity>("giahan");

        public IEnumerable<GiaHanEntity> GetAllGiaHan()
        {
            return giahanCollection.Find(a => true).ToList();
        }

        public GiaHanEntity GetGiaHanDetails(string name)
        {
            var giahandetails = giahanCollection.Find(m => m.TENDG == name).FirstOrDefault();
            return giahandetails;
        }
        public void Create(GiaHanEntity GiaHanData)
        {
            giahanCollection.InsertOne(GiaHanData);
        }
        public void Update(string _id, GiaHanEntity GiaHanData)
        {
            var filter = Builders<GiaHanEntity>.Filter.Eq(c => c._id, _id);
            var update = Builders<GiaHanEntity>.Update
                .Set("TENDG", GiaHanData.TENDG)
                .Set("TENSACH", GiaHanData.TENSACH)
                .Set("TUNGAY", GiaHanData.TUNGAY)
                .Set("DENNGAY", GiaHanData.DENNGAY);
            giahanCollection.UpdateOne(filter, update);
        }
        public void Delete(string TENDG, string id)
        {
            var filter = Builders<GiaHanEntity>.Filter.Eq(c => c.TENDG, id);
            giahanCollection.DeleteOne(filter);
        }
        //muontra
        public IMongoCollection<Muon_Tra_Entity> muon_traCollection =>
           _db.GetCollection<Muon_Tra_Entity>("muon_tra");

        public IEnumerable<Muon_Tra_Entity> GetAllMuon_Tra()
        {
            return muon_traCollection.Find(a => true).ToList();
        }

        public Muon_Tra_Entity GetMuon_TraDetails(string name)
        {
            var muontradetails = muon_traCollection.Find(m => m.TENDG == name).FirstOrDefault();
            return muontradetails;
        }
        public void Create(Muon_Tra_Entity muontraData)
        {
            muon_traCollection.InsertOne(muontraData);
        }
        public void Update(string _id, Muon_Tra_Entity muontraData)
        {
            var filter = Builders<Muon_Tra_Entity>.Filter.Eq(c => c._id, _id);
            var update = Builders<Muon_Tra_Entity>.Update
                .Set("TENDG", muontraData.TENDG)
                .Set("TENSACH", muontraData.TENSACH)
                .Set("SL", muontraData.SL)
                .Set("NGMUON", muontraData.NGMUON)
                .Set("NGQDTRA", muontraData.NGQDTRA)
               .Set("NGTRA", muontraData.NGTRA)
               .Set("PHATQH", muontraData.PHATQH);
            muon_traCollection.UpdateOne(filter, update);
        }
        public void Delete(string TENSACH, string TENDG, string id)
        {
            var filter = Builders<Muon_Tra_Entity>.Filter.Eq(c => c.TENDG, id);
            muon_traCollection.DeleteOne(filter);
        }
        //readers
        public IMongoCollection<ReaderEntity> readerCollection =>
          _db.GetCollection<ReaderEntity>("reader");

        public IEnumerable<ReaderEntity> GetAllReader()
        {
            return readerCollection.Find(a => true).ToList();
        }

        public ReaderEntity GetReaderDetails(string name) 
        {
            var readerdetails = readerCollection.Find(m => m.TENDG == name).FirstOrDefault();
            return readerdetails;
        }
        public void Create(ReaderEntity readerData)
        {
            readerCollection.InsertOne(readerData);
        }
        public void Update(string _id, ReaderEntity readerData)
        {
            var filter = Builders<ReaderEntity>.Filter.Eq(c => c._id, _id);
            var update = Builders<ReaderEntity>.Update
                .Set("MADG", readerData.MADG)
                .Set("TENDG", readerData.TENDG)
                .Set("DCHI", readerData.DCHI)
                .Set("NGSINH", readerData.NGSINH)
                .Set("SODT", readerData.SODT)
                .Set("NGDK", readerData.NGDK);
            readerCollection.UpdateOne(filter, update);
        }
        public void Delete(string MADG, string TENDG, string id, string SODT)
        {
            var filter = Builders<ReaderEntity>.Filter.Eq(c => c.TENDG, id);
            readerCollection.DeleteOne(filter);
        }
        //theloai
        public IMongoCollection<TheLoaiEntity> theloaiCollection =>
          _db.GetCollection<TheLoaiEntity>("theloai");

        public IEnumerable<TheLoaiEntity> GetAllTheLoai()
        {
            return theloaiCollection.Find(a => true).ToList();
        }

        public TheLoaiEntity GetTheLoaiDetails(string tentheloai)
        {
            var theloaidetails = theloaiCollection.Find(m => m.TENTHELOAI == tentheloai).FirstOrDefault();
            return theloaidetails;
        }
        public void Create(TheLoaiEntity theloaiData)
        {
            theloaiCollection.InsertOne(theloaiData);
        }
        public void Update(string _id, TheLoaiEntity theloaiData)
        {
            var filter = Builders<TheLoaiEntity>.Filter.Eq(c => c._id, _id);
            var update = Builders<TheLoaiEntity>.Update
                .Set("MATHELOAI", theloaiData.MATHELOAI)
                .Set("TENTHELOAI", theloaiData.TENTHELOAI);

            theloaiCollection.UpdateOne(filter, update);
        }
        public void Delete(string MATHELOAI, string TENTHELOAI, string id, string SODT, string TEN)
        {
            var filter = Builders<TheLoaiEntity>.Filter.Eq(c => c.TENTHELOAI, id);
            theloaiCollection.DeleteOne(filter);
        }

      
    }
}
