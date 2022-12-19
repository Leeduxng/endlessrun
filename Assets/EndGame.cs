using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class EndGame : MonoBehaviour
{
    [SerializeField] public  GameObject _endGame;
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void DeathMenu()
    {
        Time.timeScale = 0;
        _endGame.SetActive(true);
    }
}

