using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stair : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<StairMovement>().enabled = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collision.GetComponent<StairMovement>().enabled = false;
    }
}
