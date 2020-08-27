// Anthony Leland licenses this file to you under the MIT license.
namespace Tonytins.Web.Models
{
    /// <summary>
    /// Basic hero profile contains the type, affilation and server.
    /// If no info is given, the model uses it's defualt values.
    /// </summary>
    public class HeroModel
    {
        const string NA = "N/A";
        const string DEFAULT_SERVER = "Freedom";

        public string Hero { get; set; } = "Example Hero";
        public string Origin { get; set; } = NA;
        public string Archetype { get; set; } = NA;
        // I'm not sure if Affilation needs to be an array
        public string Affilation { get; set; } = NA;
        public string Image { get; set; } = "../images/brands/coh-card.png";
        public string Server { get; set; } = DEFAULT_SERVER;
        public string Shard { get; set; } = DEFAULT_SERVER;
    }
}
