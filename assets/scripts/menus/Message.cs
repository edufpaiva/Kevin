using UnityEngine;
using System.Collections;

public class Message : MonoBehaviour {
    public GameObject message;
    private bool active = false;


    public void SetMessageActive() {
        active = !active;
        message.SetActive(active);
        
    }


    
}
