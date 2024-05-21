namespace TECWEB01.Models
{
    public class Producto
    {
        public int Id { get; set; } //clave primaria
        public string Name { get; set; }
        public string Description { get; set; } 
        public decimal Price {get; set; }
        public int Amount { get; set; }
        public List<Pedido> Pedidos { get; set; }
     
    }
}
