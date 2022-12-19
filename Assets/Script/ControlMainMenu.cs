using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlMainMenu : MonoBehaviour
{

public void Play()
    {
        SceneManager.LoadScene(1);
        Time.timeScale=1;
    }
}
