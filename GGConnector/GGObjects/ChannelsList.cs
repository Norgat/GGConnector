﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GGConnector.GGObjects {
    [DataContract]
    class ChannelsListRequest {       

        [DataMember(Name = "data")]
        public ChannelsListData data { get; set; }

        [DataMember(Name = "type")]
        public string type { get; set; }
    }

    [DataContract]
    class ChannelsListData {

        [DataMember(Name = "start")]
        public int start { get; set; }

        [DataMember(Name = "count")]
        public int cout { get; set; }
    }

    [DataContract]
    public class Channel {
        [DataMember(Name = "channel_id")]
        public int channel_id { get; set; }

        [DataMember(Name = "channel_name")]
        public string channel_name { get; set; }

        [DataMember(Name = "clients_in_channel")]
        public int clients_in_channel { get; set; }

        [DataMember(Name = "users_in_channel")]
        public int users_in_channel { get; set; }
    }


    [DataContract]
    public class ChannelsList {
        [DataMember(Name = "channels")]
        public List<Channel> channels { get; set; }
    }


    [DataContract]
    class ChannelsListResponse {
        [DataMember(Name = "data")]
        public ChannelsList data { get; set; }
    }
}
