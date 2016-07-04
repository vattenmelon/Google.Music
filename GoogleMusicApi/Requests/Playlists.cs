﻿using System;
using GoogleMusicApi.Sessions;
using GoogleMusicApi.Structure;
using GoogleMusicApi.Structure.Enums;
using Newtonsoft.Json;

namespace GoogleMusicApi.Requests
{
    public class Playlists : StructuredRequest<PlaylistsRequest, Playlist>
    {
        public override string RelativeRequestUrl => "playlists";
    }

    public class PlaylistsRequest : PostRequest
    {
        [JsonProperty("creationTimestamp")]
        public string CreationTimestamp { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("lastModifiedTimestamp")]
        public string LastModifiedTimestamp { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shareState")]
        public ShareState ShareState { get; set; }

        [JsonProperty("type")]
        public PlaylistType Type { get; set; }


        public PlaylistsRequest(Session session) : base(session)
        {
        }
    }
}