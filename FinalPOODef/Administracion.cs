using System;
using System.Collections.Generic;
using System.IO;

namespace FinalPOODef
{
    class Administracion
    {
        private List<Habitacion> habitaciones = new List<Habitacion>();
        private List<Reserva> reservas = new List<Reserva>();
        private IAdmonLog log;

        public Administracion(IAdmonLog log)
        {
            this.log = log;
            for (int i = 0; i < 10; i++)
            {
                Habitacion habitacion = new Sencilla((short)(200 + (i + 1)));
                habitaciones.Add(habitacion);
            }
            for (int i = 0; i < 10; i++)
            {
                Habitacion habitacion = new Sencilla((short)(300 + (i + 1)));
                habitaciones.Add(habitacion);
            }
            for (int i = 0; i < 10; i++)
            {
                Habitacion habitacion = new Sencilla((short)(400 + (i + 1)));
                habitaciones.Add(habitacion);
            }
            for (int i = 0; i < 10; i++)
            {
                Habitacion habitacion = new Ejecutiva((short)(500 + (i + 1)));
                habitaciones.Add(habitacion);
            }
            for (int i = 0; i < 5; i++)
            {
                Habitacion habitacion = new Suite((short)(600 + (i + 1)));
                habitaciones.Add(habitacion);
            }
        }

        public List<Habitacion> Habitaciones { get => habitaciones; }
        public List<Reserva> Reservas { get => reservas; }
        internal IAdmonLog Log { get => log; }

        public void GenerarReserva(Persona usuario, short num, int diasOcu)
        {
            try
            {
                string info = "";
                foreach (var habitacion in habitaciones)
                {

                    if (habitacion.NroHabitacion == num)
                    {
                        Reserva reserva = new Reserva(usuario, habitacion, diasOcu);
                        reservas.Add(reserva);
                        //habitacion.EstadoDeOcupacion = reserva.Habitacion.EstadoDeOcupacion;
                        info = "Se generó una reserva con el usuario " + usuario.Nombre + "  en la habitación " + num + " en " + DateTime.Now.ToString() + " y se queda " +
                            "" + diasOcu + " dias";
                        log.GuardarLog(info);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el metodo GenerarReserva clase Administracion, contacte el soporte " + ex.Message);
            }
        }
        public void OcuparReserva(Reserva reserva)
        {
            try
            {
                string info = "";
                foreach (var estareserva in reservas)
                {
                    if (reserva.Habitacion.NroHabitacion == estareserva.Habitacion.NroHabitacion)
                    {
                        estareserva.CheckIn();
                        info = "Se ocupó una reserva con el usuario " + estareserva.Usuario.Nombre + "  en la habitación " + estareserva.Habitacion.NroHabitacion + " en " + DateTime.Now.ToString();
                        log.GuardarLog(info);
                        foreach (var habitacion in habitaciones)
                        {
                            if (habitacion.NroHabitacion == reserva.Habitacion.NroHabitacion)
                            {
                                //habitacion.EstadoDeOcupacion = reserva.Habitacion.EstadoDeOcupacion;
                                break;
                            }
                        }
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el metodo OcuparReserva clase Administracion, contacte el soporte " + ex.Message);
            }
        }
        public void CancelarReserva(Reserva reserva)
        {
            try
            {
                string info = "";
                Factura factura = null;
                foreach (var estareserva in reservas)
                {
                    if (reserva.Habitacion.NroHabitacion == estareserva.Habitacion.NroHabitacion)
                    {
                        if (estareserva.Estado.Equals(Reserva.estadoreserva.Ocupado))
                        {
                            factura = estareserva.CheckOut();
                            reservas.Remove(estareserva);
                            info = "Se Pagó una reserva con el usuario " + estareserva.Usuario.Nombre + "  en la habitación " + estareserva.Habitacion.NroHabitacion + " en " + DateTime.Now.ToString();
                            log.GuardarLog(info);
                        }
                        else
                        {
                            estareserva.Habitacion.EstadoDeOcupacion = Habitacion.estadoOcupacion.DISPONIBLE;
                            reservas.Remove(estareserva);
                            info = "Se Canceló una reserva con el usuario " + estareserva.Usuario.Nombre + "  en la habitación " + estareserva.Habitacion.NroHabitacion + " en " + DateTime.Now.ToString();
                            log.GuardarLog(info);
                        }
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el metodo CancelarReserva clase Administracion, contacte el soporte " + ex.Message);
            }
        }
        public void CargarDB()
        {

            StreamReader reader = new StreamReader("C:\\Users\\jcugl\\Documents\\Visual Studio 2019\\POO\\ProyectoFinal\\Version Alpha 1.3\\FinalPOODef\\DB\\Habitaciones.txt");
            string linea = reader.ReadLine();

            foreach (var habitacion in habitaciones)
            {
                string[] spliter = linea.Split('@');
                if (spliter[1] == "DISPONIBLE")
                {
                    habitacion.EstadoDeOcupacion = Habitacion.estadoOcupacion.DISPONIBLE;
                }
                else if (spliter[1] == "RESERVADO")
                {
                    habitacion.EstadoDeOcupacion = Habitacion.estadoOcupacion.RESERVADO;
                }
                else
                {
                    habitacion.EstadoDeOcupacion = Habitacion.estadoOcupacion.OCUPADO;
                }
                linea = reader.ReadLine();
            }
            reader.Close();
            StreamReader readerUsuarios = new StreamReader("C:\\Users\\jcugl\\Documents\\Visual Studio 2019\\POO\\ProyectoFinal\\Version Alpha 1.3\\FinalPOODef\\DB\\Usuarios.txt");
            StreamReader readerReservas = new StreamReader("C:\\Users\\jcugl\\Documents\\Visual Studio 2019\\POO\\ProyectoFinal\\Version Alpha 1.3\\FinalPOODef\\DB\\Reservas.txt");
            StreamReader readerCompras = new StreamReader("C:\\Users\\jcugl\\Documents\\Visual Studio 2019\\POO\\ProyectoFinal\\Version Alpha 1.3\\FinalPOODef\\DB\\Compras.txt");
            string lectorUsuario = readerUsuarios.ReadLine();
            string lectorReservas = readerReservas.ReadLine();
            string lectorCompras = readerCompras.ReadLine();
            while (lectorReservas != null)
            {
                string[] splitReservas = lectorReservas.Split('@');
                string[] splitUsuario = lectorUsuario.Split('@');

                Persona usuario = null;
                if (splitUsuario[3] == "FinalPOODef.Huesped")
                {
                    bool escolombiano = true;
                    if (splitUsuario[0] == "True")
                    {
                        escolombiano = true;
                    }
                    else
                    {
                        escolombiano = false;
                    }
                    usuario = new Huesped(escolombiano, splitUsuario[1]);
                }
                else
                {
                    bool escolombiano = true;
                    if (splitUsuario[0] == "True")
                    {
                        escolombiano = true;
                    }
                    else
                    {
                        escolombiano = false;
                    }
                    usuario = new Cliente(escolombiano, splitUsuario[1]);
                }
                usuario.Id = long.Parse(splitUsuario[2]);
                Reserva reserva = null;
                foreach (var habitacion in habitaciones)
                {
                    if (short.Parse(splitReservas[2]) == habitacion.NroHabitacion)
                    {
                        reserva = new Reserva(usuario, habitacion, int.Parse(splitReservas[4]));
                        if (splitReservas[0] == "Ocupado")
                        {
                            reserva.Estado = Reserva.estadoreserva.Ocupado;
                            reserva.Habitacion.EstadoDeOcupacion = Habitacion.estadoOcupacion.OCUPADO;
                        }
                        reserva.Fecha = DateTime.Parse(splitReservas[1]);
                        reservas.Add(reserva);
                        break;
                    }
                }
                if (!lectorCompras.Equals(""))
                {
                    string[] splitCompra = lectorCompras.Split('@');
                    for (int i = 0; i < splitCompra.Length; i++)
                    {
                        Compra compra = new Compra();
                        string[] splitAtributosCompra = splitCompra[i].Split('|');
                        compra.Fechacompra = DateTime.Parse(splitAtributosCompra[0]);
                        compra.Idcompra = short.Parse(splitAtributosCompra[1]);
                        compra.Subtotalcompra = double.Parse(splitAtributosCompra[2]);
                        List<ItemComprado> reemplazar = new List<ItemComprado>();
                        string[] splitItems = splitAtributosCompra[3].Split('-');
                        for (int j = 0; j < splitItems.Length; j++)
                        {
                            string[] splitAtributosItems = splitItems[j].Split('_');
                            Enum.TryParse(splitAtributosItems[3], out Item.categoriacompra salida);
                            Item itemsito = null;
                            if (salida == Item.categoriacompra.habitacion || salida == Item.categoriacompra.lavanderia || salida == Item.categoriacompra.planchada)
                            {
                                itemsito = new Servicio(splitAtributosItems[1], salida);
                            }
                            else
                            {
                                itemsito = new Producto(splitAtributosItems[1], salida);
                            }
                            reemplazar.Add(new ItemComprado(itemsito, short.Parse(splitAtributosItems[0])));
                        }
                        compra.Items = reemplazar;
                        reserva.Compras.Add(compra);
                    }

                }

                lectorUsuario = readerUsuarios.ReadLine();
                lectorReservas = readerReservas.ReadLine();
                lectorCompras = readerCompras.ReadLine();
            }
            readerUsuarios.Close();
            readerReservas.Close();
            readerCompras.Close();

        }
        public void EscribirDB()
        {
            try
            {
                StreamWriter writer = new StreamWriter("C:\\Users\\jcugl\\Documents\\Visual Studio 2019\\POO\\ProyectoFinal\\Version Alpha 1.3\\FinalPOODef\\DB\\Habitaciones.txt");
                foreach (var habitacion in habitaciones)
                {
                    writer.WriteLine(habitacion.NroHabitacion + "@" + habitacion.EstadoDeOcupacion.ToString() + "@" + habitacion.Costo);
                }
                writer.Close();
                StreamWriter writerReservas = new StreamWriter("C:\\Users\\jcugl\\Documents\\Visual Studio 2019\\POO\\ProyectoFinal\\Version Alpha 1.3\\FinalPOODef\\DB\\Reservas.txt");
                StreamWriter writerUsuarios = new StreamWriter("C:\\Users\\jcugl\\Documents\\Visual Studio 2019\\POO\\ProyectoFinal\\Version Alpha 1.3\\FinalPOODef\\DB\\Usuarios.txt");
                StreamWriter writerCompras = new StreamWriter("C:\\Users\\jcugl\\Documents\\Visual Studio 2019\\POO\\ProyectoFinal\\Version Alpha 1.3\\FinalPOODef\\DB\\Compras.txt");
                foreach (var reserva in reservas)
                {
                    writerReservas.WriteLine(reserva.Estado.ToString() + "@" + reserva.Fecha.ToString() + "@" + reserva.Habitacion.NroHabitacion + "@" + reserva.Habitacion.EstadoDeOcupacion.ToString() + "@" + reserva.DiasOcupacion.ToString());
                    writerUsuarios.WriteLine(reserva.Usuario.EsColombiano.ToString() + "@" + reserva.Usuario.Nombre + "@" + reserva.Usuario.Id + "@" + reserva.Usuario.GetType().ToString());
                    string compras = "";
                    string comprasitemcomprado = "";
                    string itemcompradoitem = "";
                    short contad = 0;
                    foreach (var compra in reserva.Compras)
                    {
                        compras = compras + compra.Fechacompra.ToString() + "|" + compra.Idcompra + "|" + compra.Subtotalcompra + "|";
                        short cuenta = 0;
                        comprasitemcomprado = "";
                        foreach (var itemcomprado in compra.Items)
                        {
                            itemcompradoitem = itemcomprado.Cantidad + "_" + itemcomprado.Item.Nombre + "_" + itemcomprado.Item.Costo + "_" + itemcomprado.Item.Categoria.ToString();
                            if (cuenta == compra.Items.Count - 1)
                                comprasitemcomprado = comprasitemcomprado + itemcompradoitem;
                            else
                                comprasitemcomprado = comprasitemcomprado + itemcompradoitem + "-";
                            cuenta++;
                        }
                        if (contad == reserva.Compras.Count - 1)
                            compras = compras + comprasitemcomprado;
                        else
                            compras = compras + comprasitemcomprado + "@";
                        contad++;
                    }
                    writerCompras.WriteLine(compras + "");
                }

                writerReservas.Close();
                writerUsuarios.Close();
                writerCompras.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el metodo EscribirDB clase Administracion, contacte el soporte " + ex.Message);
            }
        }

    }
}
