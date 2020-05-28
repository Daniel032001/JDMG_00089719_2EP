namespace Parcial
{
    public class address
    {
        public int idaddress { get; set; }
         
        public int iduser { get; set; }
        public string Address { get; set; }
        public address()
        {
            idaddress = 0;
            iduser = 0;
            Address = "";
        }
    }
}