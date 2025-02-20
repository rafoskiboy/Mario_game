using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coin_counter : MonoBehaviour
{
    private int coinCount = 0; // Contador de monedas
    [SerializeField] private TextMeshProUGUI coinText; // Referencia al texto UI


    // Start is called before the first frame update
    void Start()
    {
        UpdateCoinText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            coinCount++;
            UpdateCoinText();
            Destroy(other.gameObject);
        }
    }

    // Actualiza el texto en pantalla
    void UpdateCoinText()
    {
        coinText.text = "Monedas: " + coinCount;
    }

}
