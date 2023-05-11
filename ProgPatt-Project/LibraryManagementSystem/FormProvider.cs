using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class FormProvider
    {
        private static LoginForm loginInstance; // LoginForm instance

        private static LoginForm LoginInstance
        {
            get
            {
                return loginInstance;
            }
            set
            {
                loginInstance = value;
            }
        }

        // Private constructor so that you can't instantiate this class using the default constructor
        private FormProvider() { }

        public static LoginForm GetLoginForm()
        {
            if (LoginInstance == null)
            {
                LoginInstance = new LoginForm();
            }
            return LoginInstance;
        }
    }
}
