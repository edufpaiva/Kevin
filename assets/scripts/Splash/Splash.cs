using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour
{
    public float timer = 3f;
    public string nomeDaCena = "Menu";
	
	void Start ()
    {
        Invoke("FimDoSplash" , timer);

        
	}

    void FimDoSplash()
    {
        GameManager.Instance.GetComponent<SceneManager>().CarregarCena(nomeDaCena);
    }
}
