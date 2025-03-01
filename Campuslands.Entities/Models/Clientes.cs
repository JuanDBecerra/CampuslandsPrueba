﻿namespace Campuslands.Entities.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;
        public ICollection<Pedidos> Pedidos { get; set; }

    }
}
