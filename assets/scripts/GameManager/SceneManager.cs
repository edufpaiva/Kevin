using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {
    public AudioSource menu;

    public AudioSource fase01;


    public void CarregarCena(string nomeDaCena)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(nomeDaCena);
        

    }


    public void PlayMusic(AudioSource musica) {
        musica.Play();
    }

    public void StopMusic(AudioSource musica) {
        musica.Stop();
    }



}
