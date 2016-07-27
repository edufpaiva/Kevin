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


    public void SetMenuMusic() {
        for (int i = 1; i < musicas.Length; i++)
        {
            musicas[i].Stop();
        }
        if (!musicas[0].isPlaying)
        {
            musicas[0].Play();
        }

    }

    public void SetMusic(int numeroDaMusica){
        for (int i = 1; i < musicas.Length; i++)
        {
            if (numeroDaMusica == i)
            {
                musicas[i].Play();
            }
            else {
                musicas[i].Stop();
            }
            
        }
    }

}
