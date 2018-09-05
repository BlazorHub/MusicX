﻿namespace MusicX.Common.Models
{
    using System.Collections.Generic;

    public class SongArtistsTitleAndMetadata : SongArtistsAndTitle
    {
        public SongArtistsTitleAndMetadata()
            : base()
        {
        }

        public SongArtistsTitleAndMetadata(int id, IList<string> artists, string title, SongAttributes songAttributes)
            : base(artists, title)
        {
            this.Id = id;
            this.SongAttributes = songAttributes;
        }

        public int Id { get; set; }

        public SongAttributes SongAttributes { get; set; }

        public string PlayableUrl
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(this.SongAttributes?[MetadataType.YouTubeVideoId]))
                {
                    return $"https://www.youtube.com/watch?v={this.SongAttributes[MetadataType.YouTubeVideoId]}";
                }

                return null;
            }
        }

        public string ImageUrl
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(this.SongAttributes?[MetadataType.YouTubeVideoId]))
                {
                    return $"https://img.youtube.com/vi/{this.SongAttributes[MetadataType.YouTubeVideoId]}/mqdefault.jpg";
                }

                return null;
            }
        }
    }
}
