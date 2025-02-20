using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerCounter : MonoBehaviour
{
    private float timeElapsed = 0f; // Tiempo transcurrido en segundos
    [SerializeField] private TextMeshProUGUI timeText; // Referencia al texto UI

    void Start()
    {
        // Inicializa el texto al empezar
        UpdateTimeText();
    }

    void Update()
    {
        // Incrementa el tiempo con el paso de cada frame
        timeElapsed += Time.deltaTime;
        UpdateTimeText();
    }

    void UpdateTimeText()
    {
        // Calcula los segundos enteros
        int seconds = Mathf.FloorToInt(timeElapsed);
        // Calcula las centésimas de segundo (dos decimales)
        int hundredths = Mathf.FloorToInt((timeElapsed - seconds) * 100);

        // Actualiza el texto con segundos y dos decimales
        timeText.text = string.Format("Tiempo: {0}.{1:00}", seconds, hundredths);
    }
}
