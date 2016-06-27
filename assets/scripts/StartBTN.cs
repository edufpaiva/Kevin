using UnityEngine;
using System.Collections;

public class StartBTN : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame mudei isso aqui
	void Update () {
	
	}

    public void BTNLoadScene() {
        Application.LoadLevel("Fase01");
    }
}
