using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Fasecontroll : MonoBehaviour
{
    public int Fasenum;
    public int tempo2star;
    public int tempo3star;
    public int ativatodasStars;
    public GameObject tempofase;
    public GameObject[] stars;


	void Start ()
    {
        estrelas();
        bestTime();
	}
	
    void estrelas()
    {
        float tempo = GameManager.Instance.GetTempoFase(Fasenum);
        if (ativatodasStars ==1 )
        {
            if (tempo>0)
            {
                for (int i = 0; i < stars.Length; i++)
                {
                    stars[i].SetActive(true);
                }
            }
        }

        else
        {
            if (tempo>0)
            {
                stars[0].SetActive(true);

            }
            if (tempo<=tempo2star && tempo !=0)
            {
                stars[1].SetActive(true);
            }
            if (tempo<=tempo3star && tempo !=0)
            {
                stars[2].SetActive(true);
            }
        }
    }
    void bestTime()
    {
        float tempo = GameManager.Instance.GetTempoFase(Fasenum);
        tempofase.GetComponent<Text>().text = ("Best Time: " + tempo + "s");

    }
}
