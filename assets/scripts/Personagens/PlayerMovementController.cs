using UnityEngine;
using System.Collections;

public class PlayerMovementController : MonoBehaviour {



    private int direction;


    public float velocity;
    private float move;
    private bool facingRight = true;
    public float jumpVelocity;
    private bool jumped = true;
    

    public float brakeVelocity;

    public Transform groundCheck;
    public LayerMask whatIsGround;
    public bool grounded;

    private Animator mAnimator;
    private Rigidbody2D playerRB;

    public AudioSource jump;
    

    
	
	void Start () {
        mAnimator = GetComponent<Animator>();
        playerRB = GetComponent<Rigidbody2D>();


	}

    void Update() {
        if (GetComponent<PlayerController>().GetIsDead())
        {

        }
        else
        {

            if (Input.GetKeyDown(KeyCode.UpArrow)) {
                Jump();

            }
            IsGrounded();
        }


        
    }
	
	void FixedUpdate () {
        if (GetComponent<PlayerController>().GetIsDead())
        {

        }
        else {
            Movement();
        }
        Brake();
        
        
        
	}

    void Movement() {

        if (direction != 0)
        {
            move = direction;
        }
        else
        {
            move = Input.GetAxisRaw("Horizontal");
        }



        mAnimator.SetFloat("Speed", Mathf.Abs(move));

        transform.Translate(new Vector2(move, 0f) * velocity * Time.deltaTime);

        if (move > 0 && !facingRight)
        {
            Flip();
            
        }
        else if (move < 0 && facingRight)
        {
            Flip();
            
        }
        else {
            
        }



    }

    public void Jump() {
        if (!jumped) {
            //mAnimator.SetBool("Pulando", true);
            playerRB.velocity = Vector2.up * jumpVelocity;
            jump.Play();
            jumped = true;

        }

    }

    void Flip() {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void IsGrounded() {
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, whatIsGround);
        if (grounded) {
            jumped = false;  
        }
        if (playerRB.velocity.y > 1) {
            jumped = true;
        }
        mAnimator.SetBool("Grounded", grounded);
        mAnimator.SetFloat("VerticalSpeed", playerRB.velocity.y);

    }

    public void SetDirection(int direction) {
        this.direction = direction;
    }

    void Brake() {
        if (playerRB.velocity.magnitude > brakeVelocity)
        {

            playerRB.velocity = playerRB.velocity.normalized * brakeVelocity;

        }
    }

    public bool GetGrounded() {
        return grounded;
    }

}
