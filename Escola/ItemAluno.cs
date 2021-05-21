using System;
using System.Collections.Generic;
using System.Text;

namespace Escola
{  public class ItemAluno
{
    string nome;
    double nota;
    double falta;
   double rm;
        public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

        
        public double Nota
    {
        get { return nota; }
        set { nota = value; }
    }

    public double Falta
    {
        get { return falta; }
        set { falta = value; }
    }
        public double RM
        {
            get { return rm; }
            set { rm = value; }
        }

        public int Faltas { get; internal set; }
    }
}
