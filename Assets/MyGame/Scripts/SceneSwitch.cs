using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void SceneSwitcher12()
    {
        SceneManager.LoadScene("01Colorscene");
    }
    public void SceneSwitcher23()
    {
        SceneManager.LoadScene("02Countscene");
    }
    public void SceneSwitcher31()
    {
        SceneManager.LoadScene("00Startscene");
    }
}
