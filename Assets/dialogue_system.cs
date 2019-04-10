using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class superSentence {
    public string sentence;
    public float duration;
}

[ExecuteInEditMode]
public class dialogue_system : MonoBehaviour
{
    public List<superSentence> superSenteces = new List<superSentence>();
    public string[] sentences;

    public Text textBar;


    void Update() {
        textBar.text = superSenteces[0].sentence;
    }

}
