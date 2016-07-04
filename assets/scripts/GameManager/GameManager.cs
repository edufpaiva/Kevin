using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    // instance
    public static GameManager Instance;

    //Contador de mortes
    private int mortes;
    


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
        mortes = PlayerPrefs.GetInt("Mortes");
	}

    void Update() {
        if (Input.GetKeyDown(KeyCode.Q)) {
            mortes = 0;
            PlayerPrefs.SetInt("Mortes", 0);
            PlayerPrefs.Save();
        }

    }

    public void SetMortes() {
        mortes--;
        PlayerPrefs.SetInt("Mortes", mortes);
        PlayerPrefs.Save();
    }

    public int GetMortes() {
        return PlayerPrefs.GetInt("Mortes");
    }
}
