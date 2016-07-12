using UnityEngine;
using System.Collections;

public class ItemSecreto : MonoBehaviour {
    


    void Start() {

        if (GameManager.Instance.GetItemSecreto() == 1) {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col) {
        
        if (col.gameObject.tag == "Player") {
            GameManager.Instance.SetItemSecreto();
            Destroy(gameObject);
            
        }


    }

}
