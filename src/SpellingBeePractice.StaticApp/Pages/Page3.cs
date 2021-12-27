using Microsoft.AspNetCore.Components;
using SpellingBeePractice.StaticApp.Models;
using SpellingBeePractice.StaticApp.Services;

namespace SpellingBeePractice.StaticApp.Pages
{
    public partial class Page3
    {
        private IEnumerable<WordsExportViewModel> Words { get; set; }

        [Inject]
        public IWordsDataServices WordsDataServices { get; set; }
        

        protected override async Task OnInitializedAsync()
        {
            var words = await WordsDataServices.GetWordsFromCollection("page3");
            Words = words;
        }
    }
}
