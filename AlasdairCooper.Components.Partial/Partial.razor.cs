using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace AlasdairCooper.Components.Partial
{
    public partial class Partial<T>
    {
        [Inject]
        IRazorViewToStringRenderer ViewRenderer { get; set; } = null!;

        /// <summary>
        /// The name or path of the partial view that is rendered. 
        /// </summary>
        [Parameter]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The model to pass into the partial view.
        /// </summary>
        [Parameter]
        public T Model { get; set; } = default!;

        private MarkupString partialString = (MarkupString)"";

        protected override async Task OnParametersSetAsync()
        {
            partialString = (MarkupString)await ViewRenderer.RenderViewToStringAsync(Name, Model);
        }
    }
}