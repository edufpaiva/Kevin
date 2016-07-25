using UnityEngine;
using System.Collections;

public class Itemcontrole : MonoBehaviour
{
    public GameObject item;
    public int fasenum;


    void Start()
    {
        ativaItem();

    }

    void ativaItem()
    {
        GameManager.Instance.SetNumeroDaFase(fasenum);
        if (GameManager.Instance.GetItemSecreto() == 1)
        {
            item.GetComponent<Animator>().SetBool("ativa", true);
        }       
    }

}
