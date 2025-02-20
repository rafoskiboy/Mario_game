using UnityEngine;

public class Mario_movement : MonoBehaviour
{
    public float speed = 1f;  
    public float jumpForce = 10f;  
    private Rigidbody2D rb;  
    private bool isGrounded;  
    public Animator animator;

    
    private Vector3 originalScale;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
        originalScale = transform.localScale;  // Guardar la escala original de Mario
    }

    void Update()
    {
        HorizontalMove();  
        //VerticalMove();    
        Jump();
        animator.SetFloat("Speed", speed);
    }

                                           // Método para mover a Mario horizontalmente (izquierda/derecha)
    void HorizontalMove()
    {
        float moveInput = Input.GetAxis("Horizontal");  
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);  

        
        if (moveInput != 0)
        {
            transform.localScale = new Vector3(Mathf.Sign(moveInput) * Mathf.Abs(originalScale.x), originalScale.y, originalScale.z);
        }
    }

                                                  // Método para mover a Mario verticalmente (arriba/abajo)
    //void VerticalMove()
    //{
    //    float moveInput = Input.GetAxis("Vertical");  
    //    rb.velocity = new Vector2(rb.velocity.x, moveInput * speed);  
    //}

    
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);  
        }
    }

                                                         // Detectar si Mario está tocando el suelo
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = true;  
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            isGrounded = false;                                // Mario deja de estar en el suelo
        }
    }
}