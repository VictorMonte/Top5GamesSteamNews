﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Top5GamesSteamNews.Domain.Entities;

namespace Top5GamesSteamNews.Domain.Interfaces
{
    public interface IGamesServices
    {
        Task<IEnumerable<Game>> Get(int howManyGames);
    }
}
