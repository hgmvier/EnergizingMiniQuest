using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;


public class DialogueManager : MonoBehaviour
{

    public Text dialogueText;
    public Canvas secretCanvas;
    private Queue<string> _textSets;

    private void Start()
    {
        _textSets = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        _textSets.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            _textSets.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (_textSets.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = _textSets.Dequeue();
        dialogueText.text = sentence;
    }

    private void EndDialogue()
    {
        secretCanvas.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            DisplayNextSentence();
        }
    }
}
