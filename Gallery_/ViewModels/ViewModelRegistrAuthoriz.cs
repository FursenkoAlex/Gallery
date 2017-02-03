using System;
using System.Windows;
using Gallery_.Model;
using System.Windows.Input;
using Gallery_.Commands;
using Gallery_.Serialize;
using Gallery_.Views;


namespace Gallery_.ViewModels
{
    class ViewModelRegistrAuthoriz : ViewModelBase
    {
        private ViewRegistrAuthor View;
        private ListUsers listUsers = new ListUsers();
        private User user;
        IRegistrDataSerialize registrDataSerialize = new SerializeRegistrData();
        ViewGallery Gallery;

        public ViewModelRegistrAuthoriz()
        { }

        public ViewModelRegistrAuthoriz(ViewRegistrAuthor view )
        {
            View = view;
            listUsers.LoadUsers(registrDataSerialize);
        }

        private string loginUser;

        public string LoginUser
        {
            get { return loginUser; }
            set
            {
                loginUser = value;
                OnPropertyChanged();
            }
        }

        private string loginUserAuthorization;

        public string LoginUserAuthorization
        {
            get { return loginUserAuthorization; }
            set
            {
                loginUserAuthorization = value;
                OnPropertyChanged();
            }
        }

        private string pass;

        public string Password
        {
            get { return pass; }
            set
            {
                pass = value;
                OnPropertyChanged();
            }
        }

        private string passAuthorization;

        public string PassAuthorization
        {
            get { return passAuthorization; }
            set
            {
                passAuthorization = value;
                OnPropertyChanged();
            }
        }


        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        private string surname;

        public string SurName
        {
            get { return surname; }
            set
            {
                surname = value;
                OnPropertyChanged();
            }
        }

        private ICommand clickButtonOK_Rregistr;

        public ICommand ClickButtonOK_Registr
        {
            get
            {
                if (clickButtonOK_Rregistr == null)
                {
                    clickButtonOK_Rregistr = new DelegateCommands(() => ButtonOK_Registr());
                }
                return clickButtonOK_Rregistr;
            }
        }


        private void ButtonOK_Registr()
        {
            foreach (var u in listUsers.listUser)
            {
                if (u.Login == LoginUser && u.Password == Password)
                {
                    MessageBox.Show("Try again\nThis login is bysi", "Information");
                    LoginUser = Password = Name = SurName= String.Empty;
                    return;
                }
            }
            user = new User(LoginUser, Password, Name, SurName);
            listUsers.AddListUsers(user);
            listUsers.SaveUsers(registrDataSerialize);
            View.SignIn.IsSelected = true;
            LoginUser = Password = Name = SurName = String.Empty;

        }

        private DelegateCommands clickButtonCancel_Registr;

        public ICommand ClickButtonCancel_Registr
        {
            get
            {
                if (clickButtonCancel_Registr == null)
                {
                    clickButtonCancel_Registr = new DelegateCommands(() =>ButtonCancel_Registr());
                }
                return clickButtonCancel_Registr;
            }
        }

        private void ButtonCancel_Registr()
        {
            View.Close();
        }

        private DelegateCommands clickButtonOK_Authorization;

        public ICommand ClickButtonOK_Authorization
        {
            get
            {
                if (clickButtonOK_Authorization == null)
                {
                    clickButtonOK_Authorization = new DelegateCommands(()=>ButtonOK_Authorization());
                }
                return clickButtonOK_Authorization;
            }
        }

        private void ButtonOK_Authorization()
        {
            foreach (var u in listUsers.listUser)
            {
                if (u.Login == LoginUser && u.Password == Password)
                {
                    Gallery = new ViewGallery();
                    Gallery.DataContext =  new ViewModelMain();
                    Gallery.Show();
                    View.Close();
                    return;
                }
            }
            MessageBox.Show("Try again!", "Information");
        }
    }
}
