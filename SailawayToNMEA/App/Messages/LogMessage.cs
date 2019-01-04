﻿using SailawayToNMEA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyMessenger;

namespace SailawayToNMEA.App.Messages
{
    public class LogMessage : GenericTinyMessage<string>
    {
        public LogMessage(object sender, string message) : base(sender, message)
        {
        }
    }
}
