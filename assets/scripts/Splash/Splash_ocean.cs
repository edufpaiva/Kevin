using UnityEngine;
using System.Collections;

public class Splash_ocean : MonoBehaviour
{
    void Start()
    {
        Invoke("FimDoSplash", 1.5f);


    }

    void FimDoSplash()
    {
        GameManager.Instance.GetComponent<SceneManager>().CarregarCena("Splash");

    }
}