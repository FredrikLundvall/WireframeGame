﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlowtorchesAndGunpowder
{
    public class Settings
    {
        public readonly string ServerIp;
        public readonly int ServerPort;
        public readonly string MyUsername;
        public Settings(string aServerIp, int aServerPort, string aMyUsername)
        {
            ServerIp = aServerIp;
            ServerPort = aServerPort;
            MyUsername = aMyUsername;
        }
    }
}
