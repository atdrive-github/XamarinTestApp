using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.ViewModel
{
    public class ContactViewModel : ViewModelBase
    {
        #region Constructor
        public ContactViewModel()
        {
           Email = "info@atdrive.comt";
           FaceBook = "fb.com/atdrive.group";
           PhoneNumber = 01204374768;
           Twiter = "@atdrivegroup";
           Skype = "atdrive.group";
            

        }
        #endregion

        #region  Properties

        private int _phoneNumber;
        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                OnPropertyChanged(() => PhoneNumber);
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged(() => Email);
            }
        }

        private string _facebook;
        public string FaceBook
        {
            get { return _facebook; }
            set
            {
                _facebook = value;
                OnPropertyChanged(() => FaceBook);
            }
        }

        private string _twiter;
        public string Twiter
        {
            get { return _twiter; }
            set
            {
                _twiter = value;
                OnPropertyChanged(() => Twiter);
            }
        }

        private string _skype;
        public string Skype
        {
            get { return _skype; }
            set
            {
                _skype = value;
                OnPropertyChanged(() => Skype);
            }
        }

        private string _subscribeEmail;

        public string SubscribeEmail
        {
            get { return _subscribeEmail; }
            set
            {
                
                _subscribeEmail = value;
               OnPropertyChanged(()=>SubscribeEmail);
            }
        }

        #endregion

    }
}
