using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour {

	
	void Start () {
        Invoke("FimDoSplash" , 3);

        
	}

    void FimDoSplash() {
        GameManager.Instance.GetComponent<SceneManager>().CarregarCena("Menu");
    }
}
