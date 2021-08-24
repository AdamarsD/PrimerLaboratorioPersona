using Persona.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona.Negocio
{
    class NClsPersona
    {
        public String Hablar(ClsPersona persona)
        {

            return " La persona de nombre " + persona.Nombre + " esta hablando ";

        }

        public String Caminar(ClsPersona persona)
        {

            return " La persona de nombre " + persona.Nombre + " esta caminando ";

        }

        public String Reir(ClsPersona persona)
        {

            return " La persona de nombre " + persona.Nombre + " esta riendo ";

        }

        public String Observar(ClsPersona persona)
        {

            return " La persona de nombre " + persona.Nombre + " esta observando ";

        }

        // Adamaris Díaz:(
    }
}
