using UnityEngine;
using System.Collections;

public class LockControll : MonoBehaviour
{
    public GameObject[] fasesfechadas;
    public GameObject[] tempofases;


	void Start ()
    {
        if (GameManager.Instance.GetTempoFase(1)>0)
        {
            abrir(0);
        }
        if (GameManager.Instance.GetTempoFase(2)>0)
        {
            abrir(1);
        }
        abrir4();

	
	}
	
    void abrir (int x)
    {
        fasesfechadas[x].SetActive(false);
        tempofases[x].SetActive(true);
    }
    void abrir4()
    {
        int x = 1;
        for (int i = 1; i < 4; i++)
        {

            GameManager.Instance.SetNumeroDaFase(i);
            if (GameManager.Instance.GetItemSecreto() == 0)
            {
                x = 0;
            }
        }

        if (x==1)
        {
            abrir(2);
        }
    }


}
