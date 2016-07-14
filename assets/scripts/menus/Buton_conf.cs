using UnityEngine;
using System.Collections;

public class Buton_conf : MonoBehaviour
{
    private bool MenuOpctionActive = true;
    public GameObject[] matrizDesativar;
    public GameObject [] matrizAtivar; 


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
            for (int i = 0; i < matrizAtivar.Length; i++)
            {
                matrizAtivar[i].SetActive(false); 
            }
            for (int i = 0; i < matrizDesativar.Length; i++)
            {

             matrizDesativar[i].SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < matrizAtivar.Length; i++)
            {
                matrizAtivar[i].SetActive(true);
            }
            for (int i = 0; i < matrizDesativar.Length; i++)
            {
                matrizDesativar[i].SetActive(false);
            }
        }
	
	}
}
