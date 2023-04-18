using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void StartMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void SettingMenu()
    {
        SceneManager.LoadScene(2);
    }
    public void QuitMenu()
    {
        SceneManager.LoadScene(3);
    }
}
