using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {
    public AudioSource[] musicas;


    public void CarregarCena(string nomeDaCena)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(nomeDaCena);
        

    }
  


    public void PlayMusic(int i) {
        musicas[i].Play();
    }

    public void StopMusic(int i) {
        musicas[i].Stop();
    }

    public bool IsPlaying(int i) {
        return musicas[i].isPlaying;

    }

}
