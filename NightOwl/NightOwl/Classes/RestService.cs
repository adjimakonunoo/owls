using System;
using System.Net.Http;
using System.Text;
using System.IO;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Web;
using System.Net.Http.Headers;

using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;

using Plugin.Connectivity;
using MonkeyCache.FileStore;

namespace NightOwl
{
    public class staff
    {
        public string user_name { get; set; }
        public string role { get; set; }

    }
    public class New_Object
    {
        public string token { get; set; }
        public int userid { get; set; }
        public string role { get; set; }
        public List<string> permissions { get; set; }
    }
    public class Authenticator
    {
        public bool is_valid_user { get; set; } 
        
    }
    
    public class User_Credentials
    {
        public string user_name { get; set; }
        public string password { get; set; }
       
    }
    /*public class stafflist
    {
        public List<staff> staffs { get; set; }
    }*/
   /* public class credentials
    {
        public List<User_Credentials> Credentials { get; set;}
    }*/
    public class RestService
    {
        
        public List<staff> objstaff  { get; set; }
         HttpClient Client = new HttpClient();
        //bool isvalid = false;
        
        public Authenticator Myobj { get; set; }

        public New_Object hello { get; set; }

        


        private Task DisplayAlert(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }


        
        public async Task<Authenticator> PostJSON<T>(string url , T body)
        {

           if (NetworkCheck.Internet())
            {
                var uri = new Uri(string.Format(url, string.Empty));
                
                //Setting header for the uri
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Convert Login details into a Json format
                var json = JsonConvert.SerializeObject(body);

                var StringContent = new StringContent(json, Encoding.UTF8, "application/json");
                try
                {
                    
                    var response = await Client.PostAsync(uri, StringContent);

                    //read response from the server as a string
                    var tert = await response.Content.ReadAsStringAsync();
                    //System.Diagnostics.Debug.WriteLine(tert);

                    if (response.IsSuccessStatusCode)
                    {
                        //Convert the Json object received from the server into Authenticator object

                        Myobj = JsonConvert.DeserializeObject<Authenticator>(tert);
                        //System.Diagnostics.Debug.WriteLine(Myobj);
                        //System.Diagnostics.Debug.WriteLine("succesfully saved");
                    }
                }catch(Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex);
                }
            }
            Task.WaitAll();
            return null;
        }
       public async Task<New_Object> GetJSON(string url, string username, string Password, bool forceRefresh = false)
        {
            var json = string.Empty;
            System.Diagnostics.Debug.WriteLine("step one");
            //check if we are connected, else check to see if we have valid data
            if (!CrossConnectivity.Current.IsConnected)
                json = Barrel.Current.Get<string>(url);
            else if (!forceRefresh && !Barrel.Current.IsExpired(url))
                json = Barrel.Current.Get<string>(url);
            
             System.Diagnostics.Debug.WriteLine("step two");

                //var uri = new Uri(string.Format(url, string.Empty));
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
           
            var user = username;
                var password = Password;
                var base64String = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{user}:{password}"));
                Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64String);

            try
            {
                //skip web request because we are using cached data
                if (string.IsNullOrWhiteSpace(json))
                {
                    json = await Client.GetStringAsync(url);
                    Barrel.Current.Add(url, json, TimeSpan.FromDays(1));
                }
                return await Task.Run(() =>hello= JsonConvert.DeserializeObject<New_Object>(json));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unable to get information from server {ex}");
                //probably re-throw here :)
            }
            Task.WaitAll();
            return default(New_Object);

            /*var response = await Client.GetAsync(url);

            System.Diagnostics.Debug.WriteLine(response);

            //stafflist objstafflist = new stafflist();
            if (response.IsSuccessStatusCode)
            {
                System.Diagnostics.Debug.WriteLine("step four");

                var content = await response.Content.ReadAsStringAsync();

                System.Diagnostics.Debug.WriteLine(content);
                hello = JsonConvert.DeserializeObject<New_Object>(content);
            System.Diagnostics.Debug.WriteLine(hello);
            Barrel.Current.Add(key: url, data: hello, expireIn: TimeSpan.FromDays(1));


            Task.WaitAll();
                return hello;

            }
            else
            {

                System.Diagnostics.Debug.WriteLine("is bad");
                return null;
            }
        */



        }

       /* public async Task<List<staff>> GetJSON(string url)
        {
            //Check network status   
            System.Diagnostics.Debug.WriteLine("step one");

            while
                (NetworkCheck.Internet())
            {
                System.Diagnostics.Debug.WriteLine("step two");





                //var uri = new Uri(string.Format(url, string.Empty));
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await Client.GetAsync(url);

                System.Diagnostics.Debug.WriteLine("step three");

                //stafflist objstafflist = new stafflist();
                if (response.IsSuccessStatusCode)
                {
                    System.Diagnostics.Debug.WriteLine("step four");

                    var content = await response.Content.ReadAsStringAsync();

                    System.Diagnostics.Debug.WriteLine("Step five");
                    objstaff = JsonConvert.DeserializeObject<List<staff>>(content);

                    System.Diagnostics.Debug.WriteLine("is good");
                    return objstaff;
                }
                else
                {

                    System.Diagnostics.Debug.WriteLine("is bad");
                    return null;
                }
            }

            Task.WaitAll();
            return null;

        }*/
    }

       
    }
 
        
  

 