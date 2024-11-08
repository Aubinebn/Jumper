using UnityEngine;

public class Jumper : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    private SpriteRenderer spriteRenderer;
    private bool isGrounded;
    
    public float jumpForce;
    public Sprite normalSprite;
    public Sprite jumpSprite;

    private void Start()
    {
        rigidbody = this.GetComponent<Rigidbody2D>();
        spriteRenderer = this.GetComponent<SpriteRenderer>();
        
        spriteRenderer.sprite = normalSprite;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            Jump();    
    }

    private void Jump()
    {   
        rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        
        spriteRenderer.sprite = jumpSprite;
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //-- Contact avec le sol
        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = true;
            spriteRenderer.sprite = normalSprite;
        }
    }
    
    private void OnCollisionExit2D(Collision2D collision)
    {
        //-- Contact avec le sol
        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = false;
        }
    }
}