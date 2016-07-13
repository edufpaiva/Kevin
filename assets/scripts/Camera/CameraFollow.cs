using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
    private GameObject kevin;
    private Vector3 posicao = Vector3.zero;
    public float maxRight;
    public float maxLeft;
    public float maxUp;
    public float maxDown;
    public float alturaSolo;



	// Use this for initialization
	void Start () {
        kevin = GameObject.FindGameObjectWithTag("Player");
        posicao.z = -30;
	}
	
	// Update is called once per frame
	void Update () {
        if (GameManager.Instance.GetPlayerMorto()) {
            
        } else {
            seguirKevin();
        }
        
        

        
	}


    void seguirKevin() {
        if (kevin.transform.position.x > -10 && kevin.transform.position.x < 33) {
            

        }

        posicao.x = kevin.transform.position.x;
        posicao.y = kevin.transform.position.y + alturaSolo;

        transform.position = posicao;
    }
}
