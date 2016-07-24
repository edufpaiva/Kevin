using UnityEngine;
using System.Collections;

public class NumeroDaFase : MonoBehaviour {
    public int numeroDaFase;

    void Awake() {
        GameManager.Instance.SetNumeroDaFase(numeroDaFase);
        
        

    }
    void Start() {
        if (!GameManager.Instance.GetComponent<SceneManager>().IsPlaying(numeroDaFase))
        {
            GameManager.Instance.GetComponent<SceneManager>().PlayMusic(numeroDaFase);
        }
    }

}
