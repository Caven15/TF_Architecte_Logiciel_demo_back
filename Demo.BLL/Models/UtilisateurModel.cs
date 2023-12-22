using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Models
{
    public class UtilisateurModel
    {
        public int Id { get; set; }
        public string Nom { get; set; } = String.Empty;
        public string Prenom { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public DateTime DateNaissance { get; set; }
    }
}
