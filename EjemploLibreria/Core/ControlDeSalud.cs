using System;
using System.Collections.Generic;
using System.Text;

namespace juego
{
    namespace player
    {
        public class ControlDeSalud
        {
            public int SaludMaxima { get; private set; }
            public int SaludActual { get; private set; }
            public bool EstaMuerto => SaludActual <= 0;

            public ControlDeSalud(int saludMaxima)
            {
                SaludMaxima = saludMaxima;
                SaludActual = saludMaxima;
            }
            public void RecibirDanyo(int danyo)
            {
                if (EstaMuerto)
                    return;
                SaludActual -= danyo;
                if (SaludActual < 0)
                    SaludActual = 0;
            }
            public void Curar(int cantidad)
            {
                if (EstaMuerto)
                    return;
                SaludActual += cantidad;
                if (SaludActual > SaludMaxima)
                    SaludActual = SaludMaxima;
            }
            public void ReiniciarSalud()
            {
                SaludActual = SaludMaxima;
            }
        }
    }
    namespace enemigo {
        public class ControlDeSalud
        {
            public int SaludMaxima { get; private set; }
            public int SaludActual { get; private set; }
            public bool EstaMuerto => SaludActual <= 0;

            public ControlDeSalud(int saludMaxima)
            {
                SaludMaxima = saludMaxima;
                SaludActual = saludMaxima;
            }
            public void RecibirDanyo(int danyo)
            {
                if (EstaMuerto)
                    return;
                SaludActual -= danyo;
                if (SaludActual < 0)
                    SaludActual = 0;
            }
            public void Curar(int cantidad)
            {
                if (EstaMuerto)
                    return;
                SaludActual += cantidad;
                if (SaludActual > SaludMaxima)
                    SaludActual = SaludMaxima;
            }
            public void ReiniciarSalud()
            {
                SaludActual = SaludMaxima;
            }
        }
    }
    public class Controlenemigo { 
    }
}