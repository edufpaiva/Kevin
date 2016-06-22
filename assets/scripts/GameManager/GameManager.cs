using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    public static GameManager Instance;
    // Use this for initialization

    void Awake() {
        DontDestroyOnLoad(gameObject);

        if (Instance == null)
        {
            Instance = this;
        }
        else {
            Destroy(gameObject);
        }

    }
    
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
