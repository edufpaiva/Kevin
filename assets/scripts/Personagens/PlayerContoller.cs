using UnityEngine;
using System.Collections;

public class PlayerContoller : MonoBehaviour
{
	public float velocidadeDeMovimento, alturaDePulo;
	public bool morto = false;
    private Animator mAnimator;
    private Rigidbody2D playerRB;
    private int direcao;
    private float move;
    private bool isFacingRight;
    public AudioSource evilLaugh;

    public float velocidadeDeQueda;

    //pulo do kevin 
    public Transform groundCheck;
    private float groundRadius = 0.1f;
    public LayerMask whatIsGround;
    private bool naoPulou = true;
    public bool noChao = false;

    // Use this for initialization
    void Start ()
	{
        mAnimator = GetComponent<Animator>();
        playerRB = GetComponent<Rigidbody2D>();
        evilLaugh.GetComponent<AudioSource>();
	}

    // Update is called once per frame
    void Update() {
        if (!morto)
        {       
            SetNoChao();   
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Pular();
            }

        }
    }
    
    
	void FixedUpdate ()
	{
        if (!morto)
        {
            Movement();
            Freio();
            
        }
        else
        {
            naoPulou = false;

            Invoke("Morreu", 2f);

        }
    }



    public void Movement()
    {

        if (direcao != 0) {
            move = direcao;
        } else {
            move = Input.GetAxisRaw("Horizontal");
        }
        
        mAnimator.SetFloat("Speed", Mathf.Abs(move));

        transform.Translate(new Vector2(move, 0f) * velocidadeDeMovimento * Time.deltaTime);
        //playerRB.velocity = new Vector2(move * velocidadeDeMovimento, playerRB.velocity.y);
        if (move < 0 && !isFacingRight)
        {
            Flip();
        }
        else if (move > 0 && isFacingRight)
        {
            Flip();
        }

    }

    void Flip()
    {

        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;

    }

    void SetNoChao()
    {
        noChao = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        if (noChao)
        {
            naoPulou = true;
            mAnimator.SetBool("Pulando", false);

        }
    }

    void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "Death") {

			morto = true;
            mAnimator.SetBool("Morrendo", true);
            evilLaugh.Play();
        }
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		/*if (col.gameObject.tag == "Chao") {
			naoPulou = true;
            mAnimator.SetBool("Pulando", false);

        }*/
	}


	void Morreu ()
	{
		Application.LoadLevel (Application.loadedLevel);
	}

    public void Botoes(int direcao){
        

        this.direcao = direcao;
    }

    public void Pular() {

        if (naoPulou)
        {
            naoPulou = false;
            mAnimator.SetBool("Pulando", true);
            playerRB.velocity = Vector2.up * alturaDePulo;
        }
    }

    void Freio()
    {
        if (playerRB.velocity.magnitude > velocidadeDeQueda)
        {

            playerRB.velocity = playerRB.velocity.normalized * velocidadeDeQueda;

        }
    }
}