using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPractica1
{
    public class clsPractica1
    {
        #region "Atributos"
        float fltA, fltB, fltC, fltArea;
        string strError;
        #endregion

        #region "Constructor"
        public clsPractica1()
        {
            fltA = 0;
            fltB = 0;
            fltC = 0;
            fltArea = 0;
            strError = string.Empty; // "";
        }
        #endregion

        #region "Propiedades"
            public float ladoA
            {
                set { fltA = value; }
            }
            public float ladoB
            {
                set { fltB = value; }
            }

            public float ladoC
            {
                set { fltC = value; }
            }
            public string Error
            {
                get { return strError; }
            }
        #endregion

        #region "Métodos Privados"
        private bool Validar()
        {
            if (fltA <= 0)
            {
                strError = "Valor del lado A no es válido";
                return false;
            }
            if (fltB <= 0)
            {
                strError = "Valor del lado B no es válido";
                return false;
            }
            if (fltC <= 0)
            {
                strError = "Valor del lado C no es válido";
                return false;
            }

            if (fltA + fltB < fltC || fltA + fltC < fltB || fltB + fltC < fltA)
            {
                strError = "No se puede construir un triángulo con dichos valores";
                return false;
            }

                return true;
                // Consulta: Falta validar método de desigualdad de un triangulo a + b > c, b + c> a, a + c > b
        }
        #endregion

        #region "Métodos Públicos"
            public bool hallarArea()
            {
            float fltP = 0; // Variable local
            
                if(!Validar())
                {
                    return false;
                }

                fltP = (fltA + fltB + fltC) / 2f;
                fltArea = Convert.ToSingle(Math.Sqrt(fltP * (fltP - fltA) * (fltP - fltB) * (fltP - fltC)));

                return true;
            }
        #endregion
    }
}
