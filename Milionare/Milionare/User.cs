using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milionare
{
    public class User
    {
        public static int wallet, id;
        public static string name, nickname, rank, email;
        public User(int ident, string nm, string nk, string rnk, int wall, string mail)
        {
            id = ident;
            name = nm;
            nickname = nk;
            rank = rnk;
            wallet = wall;
            email = mail;
        }
    }
}
