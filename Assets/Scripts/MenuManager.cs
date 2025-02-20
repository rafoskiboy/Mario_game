using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
    public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene"); //Cambia a la escena principal

    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene("MainMenu"); // Cambia a la escena del menú
    }

}
