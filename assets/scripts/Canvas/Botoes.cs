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

    public void SetNumeroDaProximaFase() {
        GameManager.Instance.SetNumeroDaFase(GameManager.Instance.GetNumeroDaFase() + 1);
    }

    public void SetNumeroDaProximaFase(int numeroDaFase) {
        GameManager.Instance.SetNumeroDaFase(numeroDaFase);
    }
}
