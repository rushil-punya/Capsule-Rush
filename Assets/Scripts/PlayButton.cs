using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayButton : MonoBehaviour
{
    
    public void PlayGame()
    {
        SceneManager.LoadScene("FPS Scene");
    }
    public void Secret()
    {
        SceneManager.LoadScene("SecretMessage");
    }
}
