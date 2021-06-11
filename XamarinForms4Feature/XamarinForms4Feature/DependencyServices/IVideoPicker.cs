using System;
using System.Threading.Tasks;

namespace XamarinForms4Feature.DependencyServices
{
    public interface IVideoPicker
    {
        Task<string> GetVideoFileAsync();
    }
}
