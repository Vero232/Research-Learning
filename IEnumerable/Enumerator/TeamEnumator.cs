using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerator
{
    internal class TeamEnumerator : IEnumerator<Player>
    {

        private readonly IList<Player> _players;

        public TeamEnumerator(IList<Player> players) {
            _players = players;
            Index = -1;

        }

        public int Index { get; private set; }

        public Player Current { get; private set; } // the current property in an iteration

        object IEnumerator.Current => Current; //returns the current iteration

        public void Dispose()
        {
            Index = 0;
            Current = _players[0];
        }

        public bool MoveNext(){
            Index++;

            if(Index < _players.Count) 
                Current = _players[Index];
            return Index < _players.Count;
        }

        public void Reset() { 
            Index = 0;
        }
    }
}

