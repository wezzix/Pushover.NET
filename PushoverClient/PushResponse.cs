﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PushoverClient
{
    /// <summary>
    /// Represents a response message from the Pushover API
    /// </summary>
    [DataContract]
    public class PushResponse
    {
        [DataMember(Name="status")]
        public int Status
        {
            get;
            set;
        }

        [DataMember(Name = "request")]
        public string Request
        {
            get;
            set;
        }

        [DataMember(Name = "errors")]
        public List<string> Errors
        {
            get;
            set;
        }
    }
}
