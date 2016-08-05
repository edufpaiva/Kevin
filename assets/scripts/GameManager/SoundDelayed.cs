using UnityEngine;
using System.Collections;

public class SoundDelayed : MonoBehaviour {
    public AudioSource som;
    public float timer;

	
	void Start () {
        som.PlayDelayed(timer);
	}
	

}
