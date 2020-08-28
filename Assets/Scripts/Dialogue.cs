using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New Dialogue", menuName = "Dialogue")]
public class Dialogue: ScriptableObject
{
    public string npcName;

    
    public DialogueSlide[] slides;

    [System.Serializable]
    public struct DialogueSlide
    {
        public Sprite sprite;

        [TextArea(minLines: 3, maxLines: 10)]
        public string text;
    }
}
