namespace Parcial
{
    public class product
    {
        public int idproduct { get; set; }
         
        public int idbusiness { get; set; }
        public string name { get; set; }
        public product()
        {
            idproduct = 0;
            idbusiness = 0;
            name = "";
        }
    }
}