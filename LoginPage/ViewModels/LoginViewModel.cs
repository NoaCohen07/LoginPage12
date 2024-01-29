using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginPage.Services;
using LoginPage.Models;

namespace LoginPage.ViewModels
{
    internal class LoginViewModel:ViewModelBase
    {
        private string userName;
        public string UserName
        {
            get { return this.userName; }
            set
            {
                this.userName = value;
                OnPropertyChanged();
            }
        }

        private string password;
        public string PassWord
        {
            get { return this.password; }
            set 
            { 
                this.password = value; 
                OnPropertyChanged();
            }
        }
        private Color messagesColor;
        public Color MessagesColor
        {
            get { return this.messagesColor; }
            set
            {
                this.messagesColor = value;
                OnPropertyChanged();
            }
        }
        private string messages;
        public string Messages
        {
            get { return this.messages; }
            set
            {
                this.messages= value;
                OnPropertyChanged();
            }
        }
        public Command LoginStatus { get; set; }
        public Command Cancel { get;set; }
        public LoginViewModel()
        {
            LoginStatus = new Command(GetUser);
            Cancel = new Command(GetCancel);
        }
       
        private int totalUsers;
        public int TotalUsers
        {
            get { return this.totalUsers; }
            set
            {
                this.totalUsers = value;
                OnPropertyChanged();
            }
        }
        public void GetUser()
        {
            UserService service=new UserService();
            User user = new User(UserName, PassWord);
            bool success = service.Login(user);
            if(success)
            {
                MessagesColor = Colors.Green;
                Messages = "Login succeeded!";
            }
            else
            {
                MessagesColor = Colors.Red;
                Messages = "Login failed!";
            }

        }
        public void GetCancel()
        {
            UserName = "";
            PassWord = "";
        }
    }
}
