using UnityEngine;
using System.Collections;

public class ItemSecretoShiny : MonoBehaviour {
    public float rotationVelocity;
    public float otherRotationVelocity;

	// Use this for initialization
	void Start () {
	   
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(Vector3.left, rotationVelocity * Time.deltaTime);
        transform.Rotate(Vector3.up, otherRotationVelocity * Time.deltaTime);




    }
}
