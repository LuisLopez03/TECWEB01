namespace TECWEB01.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public double Cantidad { get; set; }

        public int ProductoId { get; set; }   // clave foranea (producto)
        public int ClienteId { get; set; }    // cave foranea (cliente)

        public Producto? Producto { get; set; }
        public Cliente? Cliente { get; set; }


    }
}
