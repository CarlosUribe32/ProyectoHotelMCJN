using System;
using System.IO;

namespace FinalPOODef
{
    class TXTFile : IAdmonLog
    {
        public TXTFile()
        {
        }
        public void GuardarLog(String info)
        {
            try
            {
                StreamWriter writer = File.AppendText("C:\\Users\\jcugl\\Documents\\Visual Studio 2019\\POO\\ProyectoFinal\\Version Alpha 1.3\\FinalPOODef\\logs\\log.txt");
                writer.WriteLine(info);
                writer.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en el metodo GuardarLog clase TXTFile, comuniquese porfa con soporte" + ex.Message);
            }
        }
    }
}
