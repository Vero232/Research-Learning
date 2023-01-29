using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerator
{
    internal class Team : IEnumerable<Player>
    {
        private readonly IList<Player> _players = new List<Player>
        {
            new Player("Player", "11"),
            new Player("Player", "21"),
            new Player("Player", "32"),
            new Player("Player", "43"),


        };

        private readonly TeamEnumerator _enumerator;

        public Team()
        {
            _enumerator = new TeamEnumerator(_players);
        }


        public IEnumerator<Player> GetEnumerator()
        {
           return _enumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _enumerator;
        }
    }
}
