using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NightOwl
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfrimPassword { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public User() { }

        public User(string FirstName, string LastName, string Email, string Username, string Password, string ConfirmPassword)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Username = Username;
            this.Password = Password;
            this.ConfrimPassword = ConfrimPassword;
        }
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
        RestService userRequest = new RestService();

        public bool CheckRegInfo()
        {
            try
            {
                if (!this.FirstName.Equals("") && !this.LastName.Equals("") && !this.Email.Equals("")
                    && !this.Username.Equals("") && !this.Password.Equals("") && !this.ConfrimPassword.Equals(""))

                    return true;
                else
                    return false;
            }catch(NullReferenceException)
            {
                return false;
            }
        }
        public bool CheckInformation()
        {
            try
            {
                /*staff getall = new staff { user_name = this.Username, role = this.Password };
                
                var h = Task.Run(()=> userRequest.GetJSON("http://10.0.1.16:3000/user"));
                h.Wait();



                foreach(var item in userRequest.objstaff)
                {

                    System.Diagnostics.Debug.WriteLine("User Name:" +item.user_name +"  "+"Password:"+item.role);
                }*/



                New_Object getall = new New_Object();


                var h = Task.Run(() => userRequest.GetJSON("http://a2acb5c7.ngrok.io/api/token", this.Username, this.Password));
                h.Wait();
                System.Diagnostics.Debug.WriteLine("step six");
           


            /*foreach(var item in userRequest.hello)
            {

                System.Diagnostics.Debug.WriteLine("Token:" +item.token +"  "+"User Id:"+item.userid +" "+"role"+item.role +" "+"Permissions"+item.permissions);
            }*/


            /*User_Credentials Credentials = new User_Credentials { user_name = this.Username, password = this.Password };
            Authenticator test = new Authenticator();

             var t= Task.Run(()=> userRequest.PostJSON("http://a2acb5c7.ngrok.io/api/token", Credentials));
            t.Wait();

            System.Diagnostics.Debug.WriteLine("step six");*/

            
                if (!userRequest.hello.token.Equals(""))

                    return true;
                else
                    return false;

            }catch(System.NullReferenceException)
            {
                return false;
            }




            /*  if (userRequest.Myobj.is_valid_user.Equals(true))

                  return true;
              else
                  return false;

          }*/

           
            
        }
    }
}
