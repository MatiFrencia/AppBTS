﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppBTS.Datos;

namespace AppBTS.Negocio
{
    class Usuario
    {
        private int id_usuario;
        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }

        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Id_perfil { get; set; }
        public string Estado { get; set; }
        public bool Borrado { get; set; }
        
        public int validarUsuario(string nombre,string clave)
        {
            string consulta = "SELECT * FROM Usuarios WHERE usuario='" + nombre + "' AND password='" + clave+"'";
            
            BDHelper oDatos = new BDHelper();
            DataTable tabla = oDatos.consultar(consulta);
            if (tabla.Rows.Count > 0)
                return (int)tabla.Rows[0][0];
            else
                return 0;
        }
        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT * FROM Usuarios WHERE borrado = 0 order by usuario";

            BDHelper oDatos = new BDHelper();
            return oDatos.consultar(consulta);
        }
    }
}
