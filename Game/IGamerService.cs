using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    interface IGamerService
    {
        void Add(IGamerService gamer);
        void Update(IGamerService gamer);
        void Delete(IGamerService gamer);
    }
}
