﻿using System;

using AppKit;

namespace SignalRMac
{
    static class MainClass
    {
        static void Main (string[] args)
        {
            NSApplication.Init ();
            NSApplication.Main (args);
        }
    }
}
