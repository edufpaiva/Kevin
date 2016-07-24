using UnityEngine;
using System.Collections;

public class BotaoDestruidor : MonoBehaviour {
    public GameObject botao;
    public GameObject[] toBeDestroyed;
    public GameObject[] toBeActive;
    public float timer = 5;
    public float intervalo = 0.3f;
	
    void OnCollisionStay2D(Collision2D col) {
        
        if (col.gameObject.tag == "Player")
        {
            botao.GetComponent<Animator>().SetBool("Pressed", true);
            if (toBeDestroyed.Length >= 1)
            {
                for (int i = 0; i <  toBeDestroyed.Length; i++)
                {
                    Destroy(toBeDestroyed[i], timer);
                    timer += intervalo;
                }
            }

            if (toBeActive.Length >= 1)
            {
                for (int i = 0; i < toBeActive.Length; i++)
                {
                    toBeActive[i].SetActive(true);
                    
                }
            }

        }
    }

    
}
