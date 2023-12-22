﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Data
{
    public class UtilisateurData
    {
        public int Id { get; set; }
        public string Nom { get; set; } = String.Empty;
        public string Prenom { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public DateTime DateNaissance { get; set; }
    }
}
