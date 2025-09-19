
namespace Grocery.Core.Models
{
    public partial class Client : Model
    {
        private string _emailAddress {  get; set; }
        private string _password { get; set; }
        public Client(int id, string name, string emailAddress, string password) : base(id, name)
        {
            _emailAddress=emailAddress;
            _password=password;
        }

        public string GetEmail()
        {
            return _emailAddress;
        }

        public string GetPasswordHash()
        {
            return _password;
        }
    }
}
