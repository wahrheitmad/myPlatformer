using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Disable()
    {
        AudioManager.setSound();
    }

    public void Able()
    {
         AudioManager.setSound();
    }


       public void ExitGame()
    {
       Application.Quit();
    }

}
