using LibraryData.Models;
using LibraryService.Models;
using System.Collections.Generic;
using System.Data;

namespace LibraryService
{
    public interface ILibraryService
    {
        //IEnumerable<Asset> GetAllAssets();
        //Asset GetAssetById(int Id);
        //IEnumerable<Branch> GetAllBranches();
        //Branch GetBranchById(int Id);
        CreateBranchResponse CreateBranch(CreateBranchRequest request);
        CreateBookResponse CreateBook(CreateBookRequest request);
        CreateVideoResponse CreateVideo(CreateVideoRequest request);
        IEnumerable<Book> GetAllBooksForBranch(int BranchId);
        //bool CreateVideo(Video video);
        IEnumerable<Video> GetAllUsersList();
    }
}
