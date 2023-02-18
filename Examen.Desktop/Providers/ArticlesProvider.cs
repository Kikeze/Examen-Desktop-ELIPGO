using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using Examen.Data.Models;
using Examen.Data.DTO;
using Examen.Data.Results;

namespace Examen.Desktop.Providers
{
    public class ArticlesProvider
    {
        private string sAPIUrl = @"https://localhost:7051/Services/";

        public List<ArticleDTO> GetArticles(int StoreId)
        {
            List<ArticleDTO> oReturn = new List<ArticleDTO>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(sAPIUrl);

                // HTTP GET
                var action = "Articles";
                if(StoreId > 0)
                {
                    action = $"Articles/Stores/{StoreId}";
                }

                var responseTask = client.GetAsync(action);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    // OK
                    var okTask = result.Content.ReadAsStringAsync();
                    okTask.Wait();

                    var oArticles = JsonSerializer.Deserialize<ArticlesResult>(okTask.Result);
                    oReturn.AddRange(oArticles.Articles);
                }
                else
                {
                    // ERROR
                    var errorTask = result.Content.ReadAsStringAsync();
                    errorTask.Wait();

                    var oError = JsonSerializer.Deserialize<ErrorResult>(errorTask.Result);
                    MessageBox.Show(oError.Error_Msg, $"ERROR {oError.Error_Code}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return oReturn;
        }

        public ArticleDTO GetArticle(int ArticleId)
        {
            ArticleDTO oReturn = new ArticleDTO();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(sAPIUrl);

                // HTTP GET
                var responseTask = client.GetAsync($"Articles/{ArticleId}");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    // OK
                    var okTask = result.Content.ReadAsStringAsync();
                    okTask.Wait();

                    var oArticle = JsonSerializer.Deserialize<ArticleResult>(okTask.Result);
                    oReturn = oArticle.Article;
                }
                else
                {
                    // ERROR
                    var errorTask = result.Content.ReadAsStringAsync();
                    errorTask.Wait();

                    var oError = JsonSerializer.Deserialize<ErrorResult>(errorTask.Result);
                    MessageBox.Show(oError.Error_Msg, $"ERROR {oError.Error_Code}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return oReturn;
        }

        public ArticleDTO InsertArticle(Article NewArticle)
        {
            ArticleDTO oReturn = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(sAPIUrl);

                // HTTP POST
                var contentData = new StringContent(JsonSerializer.Serialize(NewArticle), UnicodeEncoding.UTF8, "application/json");
                var responseTask = client.PostAsync("Articles", contentData);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    // OK
                    var okTask = result.Content.ReadAsStringAsync();
                    okTask.Wait();

                    var oArticles = JsonSerializer.Deserialize<ArticleResult>(okTask.Result);
                    oReturn = oArticles.Article;
                }
                else
                {
                    // ERROR
                    var errorTask = result.Content.ReadAsStringAsync();
                    errorTask.Wait();

                    var oError = JsonSerializer.Deserialize<ErrorResult>(errorTask.Result);
                    MessageBox.Show(oError.Error_Msg, $"ERROR {oError.Error_Code}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return oReturn;
        }

        public ArticleDTO UpdateArticle(Article EditedArticle)
        {
            ArticleDTO oReturn = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(sAPIUrl);

                // HTTP PUT
                var contentData = new StringContent(JsonSerializer.Serialize(EditedArticle), UnicodeEncoding.UTF8, "application/json");
                var responseTask = client.PutAsync("Articles", contentData);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    // OK
                    var okTask = result.Content.ReadAsStringAsync();
                    okTask.Wait();

                    var oArticles = JsonSerializer.Deserialize<ArticleResult>(okTask.Result);
                    oReturn = oArticles.Article;
                }
                else
                {
                    // ERROR
                    var errorTask = result.Content.ReadAsStringAsync();
                    errorTask.Wait();

                    var oError = JsonSerializer.Deserialize<ErrorResult>(errorTask.Result);
                    MessageBox.Show(oError.Error_Msg, $"ERROR {oError.Error_Code}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return oReturn;
        }
        public void DeleteArticle(int ArticleId)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(sAPIUrl);

                // HTTP DELETE
                var responseTask = client.DeleteAsync($"Articles/{ArticleId}");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    // OK
                    var okTask = result.Content.ReadAsStringAsync();
                    okTask.Wait();

                    //var oArticles = JsonSerializer.Deserialize<ArticleResult>(okTask.Result);
                }
                else
                {
                    // ERROR
                    var errorTask = result.Content.ReadAsStringAsync();
                    errorTask.Wait();

                    var oError = JsonSerializer.Deserialize<ErrorResult>(errorTask.Result);
                    MessageBox.Show(oError.Error_Msg, $"ERROR {oError.Error_Code}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return;
        }


    }
}
