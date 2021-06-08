using System;

namespace Practicas
{
    public class lector
    {
        private string mNombre;
        private string mLetras;
        private string mNumeros;
        public const string cuandoesletra = "Es tipo string y debe ser entero";
        public const string cuandoesnumero = "Es tipo numero y debe ser letra";


        private lector()
        {
        }

        private lector(string nombre, string letras,string numeros)
        {
            mNombre = nombre;
            mLetras = letras;
            mNumeros = numeros;
        }
        public string Nombre
        {
            get { return mNombre; }
        }

        public string Letras
        {
            get { return mLetras; }
        }

        public string Numero
        {
            get { return mNumeros; }
        }
    }
}
