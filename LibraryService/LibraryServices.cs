using Dapper;
using LibraryData;
using LibraryData.Models;
using LibraryService.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace LibraryService
{
    public class LibraryServices : ILibraryService
    {
        private LibraryDataContext _context;

        public LibraryServices(LibraryDataContext context)
        {
            _context = context;
        }

        public CreateBookResponse CreateBook(CreateBookRequest request)
        {
            var response = new CreateBookResponse();
            var entity = CommonLogic.SetMapping<CreateBookRequest, Book>(request);
            try
            {
                _context.Add(entity);
                _context.SaveChanges();
                response.IsSuccess = true;
            }
            catch
            {
                throw new Exception();
            }
            return response;
        }

        public CreateBranchResponse CreateBranch(CreateBranchRequest request)
        {
            var response = new CreateBranchResponse();
            var entity = CommonLogic.SetMapping<CreateBranchRequest, Branch>(request);
            try
            {
                _context.Add(entity);
                _context.SaveChanges();
                response.IsSuccess = true;
            }
            catch
            {
                throw new Exception();
            }
            return response;
        }

        public CreateVideoResponse CreateVideo(CreateVideoRequest request)
        {
            var response = new CreateVideoResponse();
            var entity = CommonLogic.SetMapping<CreateVideoRequest, Video>(request);
            try
            {
                _context.Add(entity);
                _context.SaveChanges();
                response.IsSuccess = true;
            }
            catch
            {
                throw new Exception();
            }
            return response;
        }

        IEnumerable<Book> ILibraryService.GetAllBooksForBranch(int BranchId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Video> GetAllUsersList()
        {
            //IList<Asset> AssetList = new List<Asset>();
            try
            {
                //--------------when using ado.net---------------
                //using SqlConnection conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=Library_Dev_v2;Trusted_Connection=True;MultipleActiveResultSets=true");
                //conn.Open();
                //SqlCommand cmd = new SqlCommand();
                //cmd.CommandText = "select * from Assets";
                //cmd.Connection = conn;
                //SqlDataReader data = cmd.ExecuteReader();
                //while (data.Read())
                //{
                //    Asset asset = new Asset
                //    {
                //        Id = Int32.Parse(data["Id"].ToString()),
                //        Name = data["Name"].ToString()
                //    };
                //    AssetList.Add(asset);
                //}

                //-------------------using dapper-----------------------------
                using var connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=Library_Dev_v2;Trusted_Connection=True;MultipleActiveResultSets=true");
                //var affectedRows = connection.Execute(sql, new { CustomerName = "Mark" });
                //Console.WriteLine(affectedRows);
                var assets = connection.Query<Video>("select * from Assets").ToList();
                return assets;
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
