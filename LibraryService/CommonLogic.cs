using AutoMapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryService
{
    public class CommonLogic
    {
        public static object SetMapping<I,O>(I obj)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<I, O>();
            });
            IMapper iMapper = config.CreateMapper();
            var destination = iMapper.Map<I, O>(obj);
            return destination;
        }

        //public static SqlDataReader GetAdoData(string SqlQuery)
        //{
        //    try
        //    {
        //        using SqlConnection conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=Library_Dev_v2;Trusted_Connection=True;MultipleActiveResultSets=true");
        //        //var customer = connection.Query<Customer>("Select * FROM CUSTOMERS WHERE CustomerName = 'Mark'").ToList();
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand
        //        {
        //            CommandText = SqlQuery,
        //            Connection = conn
        //        };
        //        SqlDataReader data = cmd.ExecuteReader();
        //        DbDataReader db = 
                
        //        return data;
        //    }
        //    catch
        //    {
        //        throw new Exception();
        //    }
        //}
    }
}
