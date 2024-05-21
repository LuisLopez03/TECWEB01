namespace TECWEB01.Models
{
    public class Cliente
    {
        public int Id { get; set; } // clave primaria
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono {  get; set; }
        public string CedulaRuc {  get; set; }

        public List<Pedido>? Pedidos { get; set; }
        

    }   
}
