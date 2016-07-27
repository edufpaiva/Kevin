using UnityEngine;
using System.Collections;

public class Escape : MonoBehaviour {
    public string nomeDaCena;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameManager.Instance.GetComponent<SceneManager>().CarregarCena(nomeDaCena);
        }
	}
}
