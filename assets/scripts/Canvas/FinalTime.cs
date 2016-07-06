using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FinalTime : MonoBehaviour {
    private Text text;
    public GameObject relogio;

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
        text.text = "Your Time:   " + relogio.GetComponent<MostradorDeTempo>().GetTime() + "s";
    }


}
