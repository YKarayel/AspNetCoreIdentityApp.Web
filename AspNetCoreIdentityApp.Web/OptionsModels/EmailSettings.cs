using System.Reflection.Metadata.Ecma335;

namespace AspNetCoreIdentityApp.Web.OptionsModels
{
	public class EmailSettings
	{
        public string Host { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
