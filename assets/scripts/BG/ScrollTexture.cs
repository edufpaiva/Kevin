using UnityEngine;
using System.Collections;

public class ScrollTexture : MonoBehaviour {
	private Renderer mRenderer;
	public float velocityX, velocityY, tile;
	private float offsetX, offsetY;



	// Use this for initialization
	void Start () {
		mRenderer = GetComponent<Renderer>();
		mRenderer.material.mainTextureOffset = Vector2.zero;



	}
	
	// Update is called once per frame
	void Update () {
        /*if (GameManager.Instance.GetPlayerMorto() || GameManager.Instance.GetPause()) {
            return;

        }*/
		offsetX += velocityX;
		offsetY += velocityY;

		if(offsetX > tile){
			offsetX -= tile;

		}
		if(offsetY > tile){
			offsetY -= tile;
			
		}

		mRenderer.material.mainTextureOffset = new Vector2(offsetX, offsetY);

	}
}
