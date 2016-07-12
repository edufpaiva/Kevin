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

    }
    
	void Start () {
        mortes = PlayerPrefs.GetInt("Mortes");
        for (int i = 0; i < finalFases.Length; i++) {
            finalFases[i] = false;
        }
    

    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Q)) {
            mortes = 0;
            PlayerPrefs.SetInt("Mortes", 0);
            for (int i = 0; i < 4; i++) {
                PlayerPrefs.SetFloat("Fase" + (i + 1).ToString(), 0);
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
        if (PlayerPrefs.GetFloat("Fase" + numeroDaFase.ToString()) < tempo) {
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


}
