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
    public class StoresProvider
    {
        private string sAPIUrl = @"https://localhost:7051/Services/";

        public List<Store> GetStores()
        {
            List<Store> oReturn= new List<Store>();

            using (var client=new HttpClient())
            {
                client.BaseAddress = new Uri(sAPIUrl);
                
                // HTTP GET
                var responseTask = client.GetAsync("Stores");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    // OK
                    var okTask = result.Content.ReadAsStringAsync();
                    okTask.Wait();

                    var oStores = JsonSerializer.Deserialize<StoresResult>(okTask.Result);
                    oReturn.AddRange(oStores.Stores);
                }
                else
                {
                    // ERROR
                    var errorTask= result.Content.ReadAsStringAsync();
                    errorTask.Wait();

                    var oError = JsonSerializer.Deserialize<ErrorResult>(errorTask.Result);
                    MessageBox.Show(oError.Error_Msg, $"ERROR {oError.Error_Code}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return oReturn;
        }

        public Store GetStore(int Id)
        {
            Store oReturn = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(sAPIUrl);

                // HTTP GET
                var responseTask = client.GetAsync($"Stores/{Id}");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    // OK
                    var okTask = result.Content.ReadAsStringAsync();
                    okTask.Wait();

                    var oStores = JsonSerializer.Deserialize<StoreResult>(okTask.Result);
                    oReturn = oStores.Store;
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

        public Store InsertStore(Store NewStore)
        {
            Store oReturn = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(sAPIUrl);

                // HTTP POST
                var contentData = new StringContent(JsonSerializer.Serialize(NewStore), UnicodeEncoding.UTF8, "application/json");
                var responseTask = client.PostAsync("Stores", contentData);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    // OK
                    var okTask = result.Content.ReadAsStringAsync();
                    okTask.Wait();

                    var oStores = JsonSerializer.Deserialize<StoreResult>(okTask.Result);
                    oReturn = oStores.Store;
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

        public Store UpdateStore(Store EditedStore)
        {
            Store oReturn = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(sAPIUrl);

                // HTTP PUT
                var contentData = new StringContent(JsonSerializer.Serialize(EditedStore), UnicodeEncoding.UTF8, "application/json");
                var responseTask = client.PutAsync("Stores", contentData);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    // OK
                    var okTask = result.Content.ReadAsStringAsync();
                    okTask.Wait();

                    var oStores = JsonSerializer.Deserialize<StoreResult>(okTask.Result);
                    oReturn = oStores.Store;
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
        public void DeleteStore(int StoreId)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(sAPIUrl);

                // HTTP DELETE
                var responseTask = client.DeleteAsync($"Stores/{StoreId}");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    // OK
                    var okTask = result.Content.ReadAsStringAsync();
                    okTask.Wait();

                    //var oStores = JsonSerializer.Deserialize<StoreResult>(okTask.Result);
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
