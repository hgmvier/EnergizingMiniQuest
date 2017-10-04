using UnityEngine;


public class DialogueTrigger : MonoBehaviour
{

    public Dialogue dialogue;
    public Canvas secretCanvas;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            secretCanvas.gameObject.SetActive(true);
            TriggerDialogue();
        }
    }
}
