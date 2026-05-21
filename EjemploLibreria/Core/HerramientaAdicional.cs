


namespace EjemploLibreria.Core
{
    using juego.player;
    using ControlDeSaludEnemy = juego.enemigo.ControlDeSalud;
    internal class HerramientaAdicional
    {
        ControlDeSalud controlcitoJugador = new ControlDeSalud(100);
        ControlDeSaludEnemy superControlenemigo = new ControlDeSaludEnemy(1000);
    }
}
namespace juego.player {
    public class HerramientaAdicional2
    {
        ControlDeSalud controlcitoJugador = new ControlDeSalud(100);
    }
}