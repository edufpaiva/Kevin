using UnityEngine;
using System.Collections;

public class MenuSound : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameManager.Instance.GetComponent<SceneManager>().SetMenuMusic();
	}
	

}
