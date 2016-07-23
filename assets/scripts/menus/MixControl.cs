using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MixControl : MonoBehaviour
{
    public GameObject musicaSlide;
    public GameObject efeitoSlide;
    

    void Start ()
    {
        musicaSlide.GetComponent<Slider>().value = GameManager.Instance.musica;
        efeitoSlide.GetComponent<Slider>().value = GameManager.Instance.efeito;

    }

    public AudioMixer masterMixer;

    public void SetSfxLvl( float sfxLvL)
    {
        masterMixer.SetFloat("VolumeEfeitos", sfxLvL);
        GameManager.Instance.efeito = sfxLvL;
    }

    public void SetMusicLvl(float musicLvL)
    {
        masterMixer.SetFloat("VolumeMusica", musicLvL);
        GameManager.Instance.musica = musicLvL;
    }

    public void ClearVolume()
    {
        masterMixer.ClearFloat("VolumeMusica");
    }
}
