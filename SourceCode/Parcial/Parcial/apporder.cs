namespace Parcial
{
    public class apporder
    {
        public int idorder { get; set; }
        public string createdate { get; set; }
        public int idproduct { get; set; }
        public int idaddress { get; set; }

        public apporder()
        {
            idorder = 0;
            createdate = "";
            idproduct= 0;
            idaddress= 0;
            
        }
        
    }
}