using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    //int game;
    //public GameObject score;
    //public Text scoreText;
    
    public void Update()
    {
        Screen.lockCursor=false;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("FPS Scene");
    }

    public void Menu()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
