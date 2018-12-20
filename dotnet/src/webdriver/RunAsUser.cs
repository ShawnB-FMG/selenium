using System.Security;

namespace OpenQA.Selenium
{
    public class RunAsUser
    {
        public static readonly RunAsUser RunAsCurrentUser = new RunAsUser();

        private RunAsUser()
        {
            UseCurrentUser = true;
        }

        public RunAsUser(string domain, string userName, SecureString password)
        {
            UseCurrentUser = false;
            Domain = domain;
            UserName = userName;
            Password = password;
        }

        internal string Domain { get; }

        internal string UserName { get; }

        internal SecureString Password { get; }

        internal bool UseCurrentUser { get; }
    }
}
