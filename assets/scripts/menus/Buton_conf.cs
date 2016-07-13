using UnityEngine;
using System.Collections;

public class Buton_conf : MonoBehaviour
{
    private bool MenuOpctionActive = false;
    public GameObject panelmenu;
    public GameObject [] matrix; 


    // Use this for initialization
    void Start ()
    {
	}
	
	// Update is called once per frame
	public void Panel_active()
    {
        MenuOpctionActive = !MenuOpctionActive;

        if (MenuOpctionActive)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
              matrix[i].SetActive(false); 
            }
            panelmenu.SetActive(true);
        }
        else
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i].SetActive(true);
            }
            panelmenu.SetActive(false);
        }
	
	}
}
