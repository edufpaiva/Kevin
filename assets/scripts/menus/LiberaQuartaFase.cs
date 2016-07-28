using UnityEngine;
using System.Collections;

public class LiberaQuartaFase : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        for (int i = 0; i < 3; i++)
        {
            
            if (PlayerPrefs.GetInt("ItemSecreto" + (i + 1).ToString()) != 1)
            {
                
                Destroy(gameObject);

            }
            
            
        }
	}
	

}
