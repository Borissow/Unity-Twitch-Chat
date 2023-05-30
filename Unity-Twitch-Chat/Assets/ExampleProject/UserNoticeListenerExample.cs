using Lexone.UnityTwitchChat;
using System.Linq;
using UnityEngine;

public class UserNoticeListenerExample : MonoBehaviour
{
    private void Start()
    {
        IRC.Instance.OnChatMessage += IRC_OnChatMessage;
    }

    private void IRC_OnChatMessage(Chatter chatter)
    {
        if (string.IsNullOrEmpty(chatter.message) && !string.IsNullOrEmpty(chatter.tags.msgId))
        {
            Debug.Log($"<color=#fef83e><b>[USERNOTICE LISTENER]</b></color> New event message from {chatter.tags.displayName} of type {chatter.tags.msgId}");
            //Debug.Log(string.Join(',', chatter.tags.otherTags.Select(x => $"{x.name}={x.value}").ToArray()));
        }
    }
}
