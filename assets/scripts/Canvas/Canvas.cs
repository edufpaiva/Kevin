using UnityEngine;
using System.Collections;

public class Canvas : MonoBehaviour {
    void Awake() {
        DontDestroyOnLoad(gameObject);

    }

}
