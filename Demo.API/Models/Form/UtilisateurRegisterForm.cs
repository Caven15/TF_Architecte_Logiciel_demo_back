namespace Demo.API.Models.Form
{
    public class UtilisateurRegisterForm
    {
        public string Nom { get; set; } = String.Empty;
        public string Prenom { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public DateTime DateNaissance { get; set; }
    }
}
