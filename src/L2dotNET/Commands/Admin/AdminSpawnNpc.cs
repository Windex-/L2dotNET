﻿using System;
using L2dotNET.Attributes;
using L2dotNET.Models.Npcs;
using L2dotNET.Models.Player;
using L2dotNET.Tables;
using L2dotNET.Templates;

namespace L2dotNET.Commands.Admin
{
    [Command(CommandName = "spawn")]
    class AdminSpawnNpc : AAdminCommand
    {
        protected internal override void Use(L2Player admin, string alias)
        {
            var processedVar = alias.Replace("spawn",string.Empty).Trim();
            NpcTemplate npcTemp = null;

            int potentialInt;
            if (int.TryParse(processedVar, out potentialInt))
            {
                npcTemp = NpcTable.Instance.GetTemplate(potentialInt);
            }
            else
            {
                npcTemp = NpcTable.Instance.GetTemplateByName(processedVar);

            }
            if (npcTemp == null)
            {
                throw new NullReferenceException($"npcTemp is null for {processedVar}");
            }

            L2Spawn spawn = new L2Spawn(npcTemp);
            spawn.Location = new SpawnLocation(admin.X,admin.Y,admin.Z,admin.Heading, 0);
            spawn.Spawn();
            //L2Spawn spawn = new L2Spawn(18342, 50000, new []{"","",""});
            //NpcTable.Instance.SpawnNpc(Convert.ToInt32(alias.Split(' ')[1]), admin.X, admin.Y, admin.Z, admin.Heading);
        }
    }
}