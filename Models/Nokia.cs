namespace DesafioPOO.Models
{

    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int Memoria) : base(numero, modelo, imei, Memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Smartphone: Nokia. Instalando o aplicativo {nomeApp}...");
        }


    }
}