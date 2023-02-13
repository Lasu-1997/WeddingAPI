using System.ComponentModel.DataAnnotations;

namespace WeddingAPI.Models
{
    public class Users
    {

        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string userName { get; set; }
        public string password { get; set; }

    }
}
