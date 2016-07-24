using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    // instance
    public static GameManager Instance;

    //Contador de mortes
    private int mortes;

    //Verifica se o player está morto
    private bool playerMorto = false;

    //controladores de fase
    
    private bool[] finalFases = new bool[4];
    private int[] itemSecreto = new int[4];

    // audio do jogo 
    public float musica = 0f;
    public float efeito = 0f;

    private int numeroDaFase;
    private float tempoTemporario;


    void Awake() {
        DontDestroyOnLoad(gameObject);

        if (Instance == null)
        {
            Instance = this;
        }
        else {
            Destroy(gameObject);
        }
        mortes = PlayerPrefs.GetInt("Mortes");
        for (int i = 0; i < finalFases.Length; i++)
        {
            finalFases[i] = false;
            itemSecreto[i] = PlayerPrefs.GetInt("ItemSecreto" + i.ToString());

        }


    }

    void Start () {
       

    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Q)) {
            mortes = 0;
            PlayerPrefs.SetInt("Mortes", 0);
            for (int i = 0; i < 4; i++) {
                PlayerPrefs.SetFloat("Fase" + (i + 1).ToString(), 0);
                PlayerPrefs.SetInt("ItemSecreto" + i.ToString(), 0);
                itemSecreto[i] = PlayerPrefs.GetInt("ItemSecreto" + i.ToString());
            }
            PlayerPrefs.Save();
        }



    }

    public void SetMortes() {
        mortes--;
        PlayerPrefs.SetInt("Mortes", mortes);
        PlayerPrefs.Save();
    }

    public int GetMortes() {
        return PlayerPrefs.GetInt("Mortes");
    }

    public void SetPlayerMorto(bool morto) {
        this.playerMorto = morto;
    }

    public bool GetPlayerMorto() {
        return this.playerMorto;
    }

    public void SetTempoFase(float tempo) {
        if (PlayerPrefs.GetFloat("Fase" + numeroDaFase.ToString()) > tempo || PlayerPrefs.GetFloat("Fase" + numeroDaFase.ToString())  <= 1) {
            PlayerPrefs.SetFloat("Fase"+ numeroDaFase.ToString(), tempo);
            
            PlayerPrefs.Save();
        }

    }

    public float GetTempoFase(int i) {
        return PlayerPrefs.GetFloat("Fase" + (i).ToString());
    }

    public void SetFinalDaFase(int i, bool final) {
        finalFases[i - 1] = final;
    }

    public bool GetFinalDaFase(int i)
    {
        return finalFases[i - 1];
    }

    public void SetNumeroDaFase(int i) {
        numeroDaFase = i;
    }

    public int GetNumeroDaFase()
    {
        return numeroDaFase;
    }

    public void SetTempoTemporario(float tempo) {
        this.tempoTemporario = tempo;
       
    }

    public float GetTempoTemporario() {


        return tempoTemporario;
    }

    public void SetItemSecreto() {

        this.itemSecreto[numeroDaFase] = 1;
        PlayerPrefs.SetInt("ItemSecreto" + numeroDaFase.ToString(), 1);
        PlayerPrefs.Save();
    }

    public int GetItemSecreto() {

        return itemSecreto[numeroDaFase];
    }




}
