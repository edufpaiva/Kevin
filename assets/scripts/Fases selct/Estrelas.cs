using UnityEngine;
using System.Collections;

public class Estrelas : MonoBehaviour
{
    public float tempInvok;
    public int Fasenum;
    public int tempo2star;
    public int tempo3star;
    public int ativatodasStars;
    public GameObject[] stars;


    void Update()
    {
        if (GameManager.Instance.GetFinalDaFase(Fasenum))
        {
            estrelas();
        }
    }

    void estrelas()
    {
        float tempo = GameManager.Instance.GetTempoFase(Fasenum);
        if (ativatodasStars == 1)
        {
            if (tempo > 0)
            {
                for (int i = 0; i < stars.Length; i++)
                {
                    if (i==0)
                    {
                        Invoke("tempEstrela1", tempInvok);

                    }
                    if (i==1)
                    {
                        Invoke("tempEstrela2", tempInvok + 0.5f);
                    }
                    if (i==2)
                    {
                        Invoke("tempEstrela3", tempInvok + 1f);
                    }
                }
            }
        }

        else
        {
            if (tempo > 0)
            {
                Invoke("tempEstrela1", tempInvok);

            }
            if (tempo <= tempo2star && tempo != 0)
            {
                Invoke("tempEstrela2", tempInvok+0.5f);
            }
            if (tempo <= tempo3star && tempo != 0)
            {
                Invoke("tempEstrela3", tempInvok+1f);
            }
        }
    }

    void tempEstrela1 ()
    {
        stars[0].SetActive(true);
    }
    void tempEstrela2 ()
    {
        stars[1].SetActive(true);
    }
    void tempEstrela3()
    {
        stars[2].SetActive(true);
    }

}
