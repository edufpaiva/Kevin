using UnityEngine;
using System.Collections;

public class EscapeComPergunta : MonoBehaviour {
    private bool active = false;
    public GameObject tela;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SetActive();
        }
	}

    public void Exit() {
        Application.Quit();

    }

    public void SetCena(string nomeDaCena) {

        GameManager.Instance.GetComponent<SceneManager>().CarregarCena(nomeDaCena);
    }
    
    public void SetActive(){
        active = !active;
        tela.SetActive(active);

    }
}
