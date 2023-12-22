using Demo.BLL.Interfaces;
using Demo.BLL.Mapper;
using Demo.BLL.Models;
using Demo.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Services
{
    public class UtilisateurService : IUtilisateurService
    {
        private readonly IUtilisateurRepository _IUtilisateurRepository;

        public UtilisateurService(IUtilisateurRepository IUtilisateurRepository)
        {
            _IUtilisateurRepository = IUtilisateurRepository;
        }

        public void RegisterUtilisateur(UtilisateurModel model)
        {
            _IUtilisateurRepository.RegisterUtilisateur(model.BllToDal());
        }
    }
}
