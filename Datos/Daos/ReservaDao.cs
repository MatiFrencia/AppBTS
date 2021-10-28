using AppBTS.Datos.Interfaces;
using AppBTS.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBTS.Datos.Daos
{
    class ReservaDao : IReserva
    {
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT r.nroReserva,m.nroMesa,r.fechaReserva,r.horaReserva,r.nombreCliente,r.telefono,r.cantidadComensales"
                            + " FROM Reservas r, Mesas m"
                            + " WHERE r.nroReserva=r.nroReserva" +
                            " AND r.nroMesa= m.nroMesa" +
                            " AND r.fechaReserva= r.fechaReserva" +
                            " AND r.horaReserva=r.horaReserva" +
                            " AND r.nombreCliente=r.nombreCliente" +
                            " AND r.telefono=r.telefono" +
                            " AND r.cantidadComensales=r.cantidadComensales"
                            + " AND r.borrado=0"
                            + " ORDER BY r.fechaReserva DESC";
            //BDHelper oDatos = new BDHelper();
            return BDHelper.obtenerInstancia().consultar(consulta);
        }
        public DataTable RecuperarFiltrados(string desde, string hasta, string nroReserva, string nroMesa, string telefono, string comensales, string nombreCliente, string desdeHora, string hastaHora)
        {
            string consulta = "SELECT r.nroReserva,m.nroMesa,r.fechaReserva,r.horaReserva,r.nombreCliente,r.telefono,r.cantidadComensales"
                                        + " FROM Reservas r, Mesas m"
                                        + " WHERE r.nroReserva=r.nroReserva"
                                        + " AND r.nroMesa=m.nroMesa"
                                        + " AND r.borrado=0";
            consulta += " AND r.fechaReserva BETWEEN '" + desde + "' AND '" + hasta + "'";
            consulta += " AND r.horaReserva BETWEEN '" + desdeHora + "' AND '" + hastaHora + "'";

            if (nroReserva != "")
                consulta += " AND r.nroReserva=" + nroReserva;
            if (nroMesa != "")
                consulta += " AND r.nroMesa=" + nroMesa;
            if (nombreCliente != string.Empty)
                consulta += " AND r.nombreCliente= '" + nombreCliente + "'";
            if (telefono != "")
                consulta += " AND r.telefono=" + telefono;
            if (comensales != "")
                consulta += " AND r.cantidadComensales=" + comensales;

            consulta += " ORDER BY r.fechaReserva DESC";
            //BDHelper oDatos = new BDHelper();
            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public DataTable RecuperarTodosConParametro(string filtro)
        {
            string consulta = "SELECT DISTINCT r." + filtro + " FROM Reservas r WHERE borrado = 0 order by " + filtro;

            //BDHelper oDatos = new BDHelper();
            return BDHelper.obtenerInstancia().consultar(consulta);
        }

        public void Borrar(string nroReserva)
        {
            string consulta = " UPDATE Reservas"
                            + " SET borrado = 1"
                            + " WHERE nroReserva = " + nroReserva;

            //BDHelper oDatos = new BDHelper();
            BDHelper.obtenerInstancia().consultar(consulta);


        }
        public void Modificar(int numReserva, int numMesa, string dateReserva, string hourReserva, string cliente, string tel, int cantComensales)
        {
            string modificacion = "UPDATE Reservas SET nroMesa = " + numMesa.ToString() + ", fechaReserva = '" + dateReserva + "', horaReserva = '" + hourReserva + "', " +
                                  "nombreCliente = '" + cliente + "', telefono = " + tel + ", cantidadComensales = " + cantComensales.ToString() + " WHERE nroReserva = " + numReserva.ToString();
            //BDHelper oModificacion = new BDHelper();
            BDHelper.obtenerInstancia().actualizar(modificacion);
        }

        //public void AgregarReserva(string nroReserva, Reservas reserva)
        //{
        //    if (VerificarExistencia(nroReserva).Rows.Count == 0)
        //    {
        //        string alta = "INSERT INTO Reservas"
        //                        + " VALUES"
        //                        + " (" + Convert.ToInt32(nroReserva) + 
        //                        ", @nroMesa, @fechaReserva, @horaReserva, @nombreCliente, @telefono, @cantidadComensales, @borrado)";
        //        //BDHelper oAlta = new BDHelper();
        //        BDHelper.obtenerInstancia().insertarReserva(reserva, alta);
        //    }
        //    else
        //    {
        //        if (MessageBox.Show("Actualmente existe una reserva borrada con dicho número de Reserva, desea crearla nuevamente?", "Reserva existente", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
        //            LevantarReserva(nroReserva);
        //    }
        //}

        public DataTable VerificarExistencia(string nroReserva)
        {
            string verificacion = "SELECT 1 FROM Reservas WHERE nroReserva = " + nroReserva;
            //BDHelper oVerificacion = new BDHelper();
            return BDHelper.obtenerInstancia().consultar(verificacion);
        }
        public void LevantarReserva(string nroReserva)
        {
            string consulta = " UPDATE Reservas"
                            + " SET borrado = 0"
                            + " WHERE nroReserva = " + nroReserva;

            //BDHelper oDatos = new BDHelper();
            BDHelper.obtenerInstancia().consultar(consulta);
        }
        public int IdSiguiente()
        {
            string consulta = "SELECT MAX(nroReserva) FROM Reservas WHERE borrado = 0";
            //BDHelper oDatos = new BDHelper();
            DataTable idmax = BDHelper.obtenerInstancia().consultar(consulta);
            int id = 0;
            if (idmax.Rows[0][0].ToString() != "")
            {
                id = Convert.ToInt32(idmax.Rows[0][0].ToString());
            }
            return id + 1;
        }
        public void AgregarReserva(Reservas reserva)
        {
            BDHelper dm = BDHelper.obtenerInstancia();
            try
            {
                dm.Open();
                dm.BeginTransaction();

                string sql = string.Concat("INSERT INTO [dbo].[Reservas] ",
                                            "           ([nroReserva]   ",
                                            "           ,[nroMesa]         ",
                                            "           ,[fechaReserva]      ",
                                            "           ,[horaReserva]   ",
                                            "           ,[nombreCliente]   ",
                                            "           ,[telefono]    ",
                                            "           ,[cantidadComensales]    ",
                                            "           ,[borrado])      ",
                                            "     VALUES                 ",
                                            "           (@nroReserva   ",
                                            "           ,@nroMesa          ",
                                            "           ,@fechaReserva        ",
                                            "           ,@horaReserva    ",
                                            "           ,@nombreCliente     ",
                                            "           ,@telefono     ",
                                            "           ,@cantidadComensales     ",
                                            "           ,@borrado)       ");


                var parametros = new Dictionary<string, object>();
                parametros.Add("nroReserva", reserva.NroReserva);
                parametros.Add("nroMesa", reserva.NroMesa);
                parametros.Add("fechaReserva", reserva.FechaReserva);
                parametros.Add("horaReserva", reserva.HoraReserva);
                parametros.Add("nombreCliente", reserva.NombreCliente);
                parametros.Add("telefono", reserva.Telefono);
                parametros.Add("cantidadComensales", reserva.CantidadComensales);
                parametros.Add("borrado", false);
                dm.EjecutarSQLCONPARAMETROS(sql, parametros);


                dm.Commit();

            }
            catch (Exception ex)
            {
                dm.Rollback();
                throw ex;
            }
            finally
            {
                // Cierra la conexión 
                dm.Close();
            }
        }
    }
}
