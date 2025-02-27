using System.Collections.Generic;

namespace Lexone.UnityTwitchChat
{
    [System.Serializable]
    public struct ChatterEmote
    {
        [System.Serializable]
        public struct Index
        {
            public int startIndex, endIndex;
        }

        public string id;
        public Index[] indexes;
    }

    [System.Serializable]
    public struct ChatterBadge
    {
        public string id;
        public string version;
    }

    [System.Serializable]
    public struct IRCTag
    {
        public string name;
        public string value;
    }

    [System.Serializable]
    public class IRCTags
    {
        public string colorHex = string.Empty;
        public string displayName = string.Empty;
        public string channelId = string.Empty;
        public string userId = string.Empty;
        public string msgId = string.Empty;
        public string login = string.Empty;

        public ChatterBadge[] badges = new ChatterBadge[0];
        public ChatterEmote[] emotes = new ChatterEmote[0];
        public List<IRCTag> otherTags = new List<IRCTag>(10);

        public bool ContainsEmote(string emoteId)
        {
            foreach (ChatterEmote e in emotes)
            {
                if (e.id == emoteId)
                    return true;
            }

            return false;
        }

        public bool HasBadge(string badge)
        {
            foreach (ChatterBadge b in badges)
            {
                if (b.id == badge)
                    return true;
            }

            return false;
        }
    }
}