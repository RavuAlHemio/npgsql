﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Npgsql.Messages
{
    internal class ParseCompleteMessage : ServerMessage
    {
        internal override BackEndMessageCode Code { get { return BackEndMessageCode.ParseComplete; } }
        internal static readonly ParseCompleteMessage Instance = new ParseCompleteMessage();
        ParseCompleteMessage() { }
    }
}
