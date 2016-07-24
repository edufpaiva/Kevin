using UnityEngine;
using System.Collections;

public class PlayerDead : MonoBehaviour {
    public float menor = 3, maior = 5;
    public float timer = 0;
    
    // Use this for initialization
    
    void Start () {
        DontDestroyOnLoad(gameObject);
        if (menor == 0 || maior == 0)
        {

        }
        else {
            int i = Random.Range(-1, 2);
            if (i == 0) { i = Random.Range(-1, 2); }
            GetComponent<Rigidbody2D>().velocity = new Vector2(i, 1) * Random.Range(menor, maior);
        }
        
        if (timer == 0)
        {
            Destroy(gameObject, Random.Range(3, 15));
        }
        else {
            Destroy(gameObject, timer);
        }
        
    }





}
