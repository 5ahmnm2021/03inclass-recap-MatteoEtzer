using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SceneSwitcher12()
    {
        SceneManager.LoadScene("01Colorscene");
    }
    public void SceneSwitcher23()
    {
        SceneManager.LoadScene("02Countscreen");
    }
    public void SceneSwitcher31()
    {
        SceneManager.LoadScene("00Startscene");
    }
}
