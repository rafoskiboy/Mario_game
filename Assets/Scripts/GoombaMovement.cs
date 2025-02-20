using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goomba_movement : MonoBehaviour
{
    public Transform player;  
    public float speed = 2f;  

    private Vector3 originalScale;  

    void Start()
    {
        originalScale = transform.localScale;  
    }

    void Update()
    {
        MoveTowardsPlayer();  // Mover al Goomba hacia Mario horizontalmente
    }

    
    void MoveTowardsPlayer()
    {
        Vector3 direction = player.position - transform.position; 
        transform.position += direction.normalized * speed * Time.deltaTime;           // Mover al Goomba hacia Mario

                                                                               // Hacer que el Goomba se dé vuelta según la dirección
        if (direction.x < 0)    
        {
            transform.localScale = new Vector3(-Mathf.Abs(originalScale.x), originalScale.y, originalScale.z);
        }
        else if (direction.x > 0)  
        {
            transform.localScale = new Vector3(Mathf.Abs(originalScale.x), originalScale.y, originalScale.z);
        }
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            GameManager.instance.RespawnPlayer();
            //Destroy(collision.gameObject);  // Destruir a Mario si colisiona con el Goomba
            Debug.Log("Goomba ha destruido a Mario");
        }
    }
}