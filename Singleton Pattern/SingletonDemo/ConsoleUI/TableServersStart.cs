using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class TableServersStart
    {
        private List<string> servers = new List<string>();
        private int nextServer = 0;
        public int test;

        public TableServersStart() 
        {
            servers.Add("Tim");
            servers.Add("Sue");
            servers.Add("Mary");
            servers.Add("Bob");
        }


        public string GetNextServer() 
        {

            string output = servers[nextServer];

            nextServer++;

            if (nextServer >= servers.Count) 
            { 
            
                nextServer = 0;
            }


            return output;

        }

    }
}
