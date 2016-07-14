using UnityEngine;
using System.Collections;

public class PlayerSoundsController : MonoBehaviour {
    public AudioSource footstep;
    private bool playFootstep;
    private bool stepPlayed = false;
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (playFootstep && GetComponent<PlayerMovementController>().GetGrounded())
        {

            if (!stepPlayed) {
                footstep.Play();
                stepPlayed = true;
            }
            
            

        }
        else {
            footstep.Stop();
            stepPlayed = false;
        }
	}

    public void PlayStep(bool play) {

        playFootstep = play;


    }
}
