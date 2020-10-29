using System;

namespace FinalPOODef
{
    class Consola : IAdmonLog
    {
        public Consola()
        {

        }
        public void GuardarLog(String info)
        {
            try
            {
                Console.WriteLine(info);
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en el metodo GuardarLog clase Consola, comuniquese porfa con soporte" + ex.Message);
            }
        }
    }
}
