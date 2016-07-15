using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class MixControl : MonoBehaviour
{

    public AudioMixer masterMixer;

    public void SetSfxLvl( float sfxLvL)
    {
        masterMixer.SetFloat("VolumeEfeitos", sfxLvL);
    }

    public void SetMusicLvl(float musicLvL)
    {
        masterMixer.SetFloat("VolumeMusica", musicLvL);
    }

    public void ClearVolume()
    {
        masterMixer.ClearFloat("VolumeMusica");
    }
}
