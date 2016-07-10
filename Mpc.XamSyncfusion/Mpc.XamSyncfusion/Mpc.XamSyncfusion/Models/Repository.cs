using System.Collections.Generic;

namespace Mpc.XamSyncfusion.Models
{
    public static class Repository
    {
        public static List<Client> Clients()
        {
            var lst = new List<Client>();
            var c1 = new Client { Id = 1, Name = "Miguel Costa" };
            var c2 = new Client { Id = 2, Name = "Pedro Costa" };
            var c3 = new Client { Id = 3, Name = "Cristina Costa" };
            var c4 = new Client { Id = 4, Name = "António Costa" };
            var c5 = new Client { Id = 5, Name = "Maria Pinto" };

            lst.Add(c1);
            lst.Add(c2);
            lst.Add(c3);
            lst.Add(c4);
            lst.Add(c5);

            return lst;
        }
    }
}
