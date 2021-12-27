using SpellingBeePractice.StaticApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SpellingBeePractice.StaticApp.Services
{
    public interface IWordsDataServices
    {
        Task<IEnumerable<WordsExportViewModel>> GetWordsFromCollection(string colllectionName);
    }
    public class WordsDataServices : IWordsDataServices
    {
        private readonly HttpClient _httpClient;
        public WordsDataServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<WordsExportViewModel>> GetWordsFromCollection(string colllectionName)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                //Encoder=System.Text.Encodings.Web.JavaScriptEncoder.Create(Encoding.UTF8),
                WriteIndented = true
            };
            var data = await _httpClient.GetFromJsonAsync<IEnumerable<WordsExportViewModel>>($"wordlist/{colllectionName}.json", options);
            return data;
        }
    }
}
