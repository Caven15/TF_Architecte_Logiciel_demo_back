using Demo.DAL.Data;
using Demo.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace Demo.DAL.Repositories
{
    public class UtilisateurRepository : IUtilisateurRepository
    {
        private readonly Connection _connection;

        public UtilisateurRepository(Connection connection)
        {
            _connection = connection;
        }

        public void RegisterUtilisateur(UtilisateurData data)
        {
            Command command = new Command("SPUtilisateurRegister", true);

            command.AddParameter("Nom", data.Nom);
            command.AddParameter("Prenom", data.Prenom);
            command.AddParameter("Email", data.Email);
            command.AddParameter("DateNaissance", data.DateNaissance);
            _connection.ExecuteNonQuery(command);
        }
    }
}
