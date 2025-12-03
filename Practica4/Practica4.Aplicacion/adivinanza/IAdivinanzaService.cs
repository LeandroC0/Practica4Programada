namespace Practica4.Aplicacion.Adivinanza
{
    public interface IAdivinanzaService
    {
        bool Adivinar(AdivinanzaDto dto, out string correcta);
        AdivinanzaDto GetById(int id);
        object ObtenerAdivinanza();
    }
}
