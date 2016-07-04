using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MostradorDeMortes : MonoBehaviour {
    private Text text;

	void Start () {
        text = GetComponent<Text>();
        text.text = GameManager.Instance.GetMortes().ToString();
    }
}
