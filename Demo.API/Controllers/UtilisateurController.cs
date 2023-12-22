using Demo.API.Mapper;
using Demo.API.Models.Form;
using Demo.BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        private readonly IUtilisateurService _utilisateurService;

        public UtilisateurController(IUtilisateurService utilisateurService)
        {
            _utilisateurService = utilisateurService;
        }

        [HttpPost(nameof(Register))]
        public IActionResult Register(UtilisateurRegisterForm form)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _utilisateurService.RegisterUtilisateur(form.ApiToBll());
            return Ok("utilisateur ajouté avec succès !");
        }
    }
}
