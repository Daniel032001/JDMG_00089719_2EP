﻿namespace Parcial
{
    public class appuser
    {
        public int iduser { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string usertype { get; set; }

        public appuser()
        {
            iduser = 0;
            fullname = "";
            username = "";
            password = "";
            usertype = "";
        }
    }

}