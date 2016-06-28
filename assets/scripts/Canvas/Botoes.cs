using UnityEngine;
using System.Collections;

public class Botoes : MonoBehaviour {



    public void SetMusic(int i) {
        GameManager.Instance.GetComponent<SceneManager>().PlayMusic(i);
    }

    public void SetCena(string nomeDaCena) {
        GameManager.Instance.GetComponent<SceneManager>().CarregarCena(nomeDaCena);
    }

    public void StopMusic(int i) {
        GameManager.Instance.GetComponent<SceneManager>().StopMusic(i);
    }

}
