using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace PaginaCole.Interfaces
{
    public interface IPhotoService
    {
        Task<ImageUploadResult> AddPhotoAsyncHD(IFormFile file);
        Task<ImageUploadResult> AddPhotoAsyncHS(IFormFile file);
        Task<DeletionResult> DeletePhotoAsyncHD(string publicId);
        Task<DeletionResult> DeletePhotoAsyncHS(string publicId);
    }
}
