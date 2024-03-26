using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ConversationStarter : MonoBehaviour
{
     [SerializeField] private NPCConversation myConversation;
    private bool hasStartedConversation = false;

    private void OnTriggerStay(Collider other)
    {
        if (!hasStartedConversation && other.CompareTag("Player"))
        {
            ConversationManager.Instance.StartConversation(myConversation);
            hasStartedConversation = true;
        }
    }
}

