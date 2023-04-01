using System.Threading.Tasks;

namespace AlasdairCooper.Components.Partial
{
    /// <summary>
    /// Renders a razor view to a string.
    /// Credit to <see href="https://stackoverflow.com/users/6843077/hmz">HMZ</see> 
    /// for this <see href="https://stackoverflow.com/a/60842172/8853235">answer</see>.
    /// </summary>
    public interface IRazorViewToStringRenderer
    {
        Task<string> RenderViewToStringAsync<TModel>(string viewName, TModel model);
    }
}
