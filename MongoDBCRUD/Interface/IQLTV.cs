using MongoDB.Driver;
using MongoDBCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBCRUD.Interface
{
    public interface IQLTV
    {
        //BOOK
        IMongoCollection<BookEntity> bookCollection { get; }
        IEnumerable<BookEntity> GetAllBook();
        BookEntity GetBookDetails(string name);
        void Create(BookEntity bookData);
        void Update(string _id, BookEntity bookData);
        void Delete(string Name);

        //GIAHAN
        IMongoCollection<GiaHanEntity> giahanCollection { get; }
        IEnumerable<GiaHanEntity> GetAllGiaHan();
        GiaHanEntity GetGiaHanDetails(string name);
        void Create(GiaHanEntity GiaHanData);
        void Update(string _id, GiaHanEntity GiaHanData);
        void Delete (string Name,string TENDG);

        //MUONTRA
        IMongoCollection<Muon_Tra_Entity> muon_traCollection { get; }
        IEnumerable<Muon_Tra_Entity> GetAllMuon_Tra();
        Muon_Tra_Entity GetMuon_TraDetails(string name);
        void Create(Muon_Tra_Entity muontraData);
        void Update(string _id, Muon_Tra_Entity muontraData);
        void Delete(string TENSACH, string TENDG, string id);

        //READER
        IMongoCollection<ReaderEntity> readerCollection { get; }
        IEnumerable<ReaderEntity> GetAllReader();
        ReaderEntity GetReaderDetails(string name); 
        void Create(ReaderEntity readerData); 
        void Update(string _id, ReaderEntity readerData);
        void Delete(string MADG, string TENDG, string id, string SODT);
        //THELOAI
        IMongoCollection<TheLoaiEntity> theloaiCollection { get; }
        IEnumerable<TheLoaiEntity> GetAllTheLoai();
        TheLoaiEntity GetTheLoaiDetails(string name);
        void Create(TheLoaiEntity theloaiData);
        void Update(string _id, TheLoaiEntity theloaiData);
        void Delete(string MATHELOAI, string TENTHELOAI, string id, string SODT, string TEN);
    }
}
