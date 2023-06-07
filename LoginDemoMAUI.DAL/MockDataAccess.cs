using LoginDemoMAUI.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDemoMAUI.DAL
{
    public class MockDataAccess : IDataAccess
    {
        bool _loggedIn;

        public async Task<string> LoginRequest(UserLogin user)
        {
            await Task.Delay(50);

            if (user.UserName == "Admin" && user.Password == "123")
            {
                _loggedIn = true;
                string testJWT = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c";
                return testJWT;
            }
            else
                return "";
        }

        public async Task<bool> IsUserAuthenticated()
        {
            await Task.Delay(25);
            return _loggedIn;
        }
    }
}
