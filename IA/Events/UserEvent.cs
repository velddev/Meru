﻿using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.Events
{
    public class UserEvent:Event
    {
        public ProcessServerCommand processCommand = (e) =>
        {
            e.Guild.GetDefaultChannelAsync().Result.SendMessageAsync("This server event has not been set up correctly.");
        };

        public UserEvent()
        {
            CommandUsed = 0;
        }

        public async Task Check(IGuildUser e)
        {
            await Task.Run(() => processCommand(e));
        }
    }
}