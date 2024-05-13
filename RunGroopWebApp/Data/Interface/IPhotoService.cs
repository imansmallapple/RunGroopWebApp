using CloudinaryDotNet.Actions;

namespace RunGroopWebApp.Data.Interface
{
    public interface IPhotoService
    {
        //这里我们需要装新包
        Task<ImageUploadResult> AddPhotoAsync(IFormFile file);
        Task<DeletionResult> DeletePhotoAsync(string publicId);
    }
}
