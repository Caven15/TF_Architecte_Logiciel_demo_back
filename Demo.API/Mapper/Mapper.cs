using Demo.API.Models.Form;
using Demo.BLL.Models;

namespace Demo.API.Mapper
{
    public static class Mapper
    {
        internal static UtilisateurModel ApiToBll(this UtilisateurRegisterForm form)
        {
            return new UtilisateurModel()
            {
                Nom = form.Nom,
                Prenom = form.Prenom,
                Email = form.Email,
                DateNaissance = form.DateNaissance
            };
        }
    }
}
