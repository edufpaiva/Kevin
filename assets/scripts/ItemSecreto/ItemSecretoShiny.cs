using UnityEngine;
using System.Collections;

public class ItemSecretoShiny : MonoBehaviour {
    public float rotationVelocity;
    private float spin = 0;

	// Use this for initialization
	void Start () {
	   
	}
	
	// Update is called once per frame
	void Update () {


        Quaternion target = Quaternion.Euler(0, 0, spin);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * spin);


        spin = rotationVelocity;

        if (spin > 360)
        {
            spin = 0;
        }
    }
}
