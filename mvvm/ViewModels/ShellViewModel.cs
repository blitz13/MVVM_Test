/* This is more like a "Backend Code" for the UI */

using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm.ViewModels
{
    public class ShellViewModel : Screen
    {
        private string _firstName = "Juan";

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        private string _lastName = "Dela Cruz";

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string FullName
        {
            get
            {
                return $"{ _firstName } { _lastName }";
            }
            
        }

    }
}
