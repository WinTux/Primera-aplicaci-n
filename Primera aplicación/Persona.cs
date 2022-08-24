using Pais;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pais
{
    public class Persona
    {
        public int edad { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        public Persona() {
            edad = 18;
            nombre = "NA";
        }
        public Persona(int edad, string nombre) {
            this.edad = edad;
            this.nombre = nombre;
        }
        public Persona(int edad, string nombre, string apellido)
        {
            this.edad = edad;
            this.nombre = nombre;
            this.apellido = apellido;
        }

    }
    public class Animal { 
        public int edad { get; set; }
        public int patas { get; set; }
        public double peso { get; set; }
    }

    public class Estudiante : Persona { 
        public int matricula { get; set; }

        public Estudiante() {
            matricula = 0;
        }

        public Estudiante(int edadz, string nombrez, string apellidoz, int matricula) : base(edadz,nombrez, apellidoz){
            this.matricula = matricula;
        }
    }
}

namespace Universidad
{
    public class Estudiante : Persona
    {
        public int matricula { get; set; }
        public string correoInstitutcional { get; set; }

        public Estudiante()
        {
            matricula = 0;
        }

        public Estudiante(int edadz, string nombrez, string apellidoz, int matricula, string correoInstitutcional) : base(edadz, nombrez, apellidoz)
        {
            this.matricula = matricula;
            this.correoInstitutcional = correoInstitutcional;
        }
    }
}

namespace mascotas {
    using Pais;
    public partial class Perro : Animal { 
        public string nombre { get; set; }
        public string nombreDueño { get; set; }

    }

    namespace pequeños {
        public class Loro : Animal { 
            public string color { get; set; }
        }
    }
}
