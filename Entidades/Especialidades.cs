using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Especialidades
    {
        public enum Especialidad {Cardiologia,
                            Dermatologia,
                            Diabetologia,
                            Laboratorio,
                            Odontologia,
                            Oncologia,
                            Rehabilitacion,
                            Hemoterapia}


        public static Especialidad devolverEspecialidadRandom()
        {
            int numeroRandom = new Random().Next(1, 9);
            Especialidad especialidad = Especialidad.Cardiologia;
            switch (numeroRandom)
            {
                case 1: especialidad = Especialidad.Cardiologia; break;
                case 2: especialidad = Especialidad.Dermatologia; break;
                case 3: especialidad = Especialidad.Diabetologia; break;
                case 4: especialidad = Especialidad.Laboratorio; break;
                case 5: especialidad = Especialidad.Odontologia; break;
                case 6: especialidad = Especialidad.Oncologia; break;
                case 7: especialidad = Especialidad.Rehabilitacion; break;
                case 8: especialidad = Especialidad.Hemoterapia; break;
            }

            return especialidad;
        }
    }
}
