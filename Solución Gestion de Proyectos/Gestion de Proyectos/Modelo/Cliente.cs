﻿
namespace Gestion_de_Proyectos.Modelo
{
    class Cliente
    {
        public int id_cliente { get; set; }
        public string rut { get; set; }
        public string nombre { get; set; }
        public string domicilio { get; set; }
        public int id_localidad { get; set; }

        public int telefono { get; set; }
        public string email { get; set; }
        public string palabraClave { get; set; }
    }
}
