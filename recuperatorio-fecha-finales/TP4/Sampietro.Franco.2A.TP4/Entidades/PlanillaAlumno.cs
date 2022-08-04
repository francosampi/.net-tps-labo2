using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlanillaAlumno
    {
        public string nombreAlumno;
        public int[] notas;

        public PlanillaAlumno(string nombreAlumno, int[] notas)
        {
            this.nombreAlumno = nombreAlumno;
            this.notas = notas;
        }
    }
}
