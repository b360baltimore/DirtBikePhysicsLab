using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    private Queue<Dialogue.DialogueSlide> dialogueSlides;

    public Image npcSprite;
    public TMPro.TMP_Text titleText;
    public TMPro.TMP_Text npcName;
    public TMPro.TMP_Text bodyText;


    // Start is called before the first frame update
    void Start()
    {
        dialogueSlides = new Queue<Dialogue.DialogueSlide>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log(dialogue.npcName + " is explaining.");

        dialogueSlides.Clear();

        foreach (Dialogue.DialogueSlide slide in dialogue.slides)
        {
            dialogueSlides.Enqueue(slide);
        }

        DisplayNextSlide();
    }

    public void DisplayNextSlide()
    {
        if (dialogueSlides.Count == 0)
        {
            EndDialogue();
            return;
        }

        Dialogue.DialogueSlide slide = dialogueSlides.Dequeue();

        if (bodyText)
        {
            bodyText.text = slide.text;
        }

        if (npcSprite)
        {
            npcSprite.sprite = slide.sprite;
        }
    }

    private void EndDialogue()
    {
        Debug.Log("End of conversation"); 
    }
}
