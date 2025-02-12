using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAM_Leccion_NHV.Model;

namespace DAM_Leccion_NHV.ViewModel
{
    public class MainPageViewModel
    {
        public PersonasModel personasModel {  get; set; }

        public MainPageViewModel()
        {
            Consultar();
        }

        public void Consultar()
        {
            personasModel= new PersonasModel()
            {
                Nombre = "Naydelin",
                Apellido = "Hernández",
                Edad = "21"
            };

        }
    }
}
