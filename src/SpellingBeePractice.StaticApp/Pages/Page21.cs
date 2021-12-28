using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using SpellingBeePractice.StaticApp.Models;
using SpellingBeePractice.StaticApp.Services;

namespace SpellingBeePractice.StaticApp.Pages
{
    public partial class Page21
    {
        private IEnumerable<WordsExportViewModel> Words { get; set; }

        [Inject]
        public IWordsDataServices WordsDataServices { get; set; }
        [Inject]
        public IJSRuntime JSRuntime { get; set; }


        private void Collapse(string elementID)
        {
            JSRuntime.InvokeAsync<object>("Collapse", elementID);
        }
        protected override async Task OnInitializedAsync()
        {
            var words = await WordsDataServices.GetWordsFromCollection("page21");
            Words = words;
        }
    }
}
