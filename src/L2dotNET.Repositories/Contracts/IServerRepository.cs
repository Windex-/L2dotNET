﻿using System.Collections.Generic;
using L2dotNET.DataContracts;

namespace L2dotNET.Repositories.Contracts
{
    public interface IServerRepository
    {
        List<ServerContract> GetServerList();

        List<int> GetPlayersObjectIdList();

        List<AnnouncementContract> GetAnnouncementsList();

        List<SpawnlistContract> GetAllSpawns();

        bool CheckDatabaseQuery();
    }
}