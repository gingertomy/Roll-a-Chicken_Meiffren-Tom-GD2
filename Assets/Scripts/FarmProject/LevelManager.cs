using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadNewLevel(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void LoadMainMenu()
    {
      LoadNewLevel(0);  
    }
    
    public void LoadLevel1()
    {
        LoadNewLevel(1);  
    }
    public void LoadLevel2()
    {
        LoadNewLevel(2);  
    }
    
}

/*void Update()
{
    if (Input.GetKeyDown(KeyCode.L))
    {
        LoadANewLevel(buildIndex:1);
    }
}

public void LoadANewLevel(int buildIndex)
{
    SceneManager.LoadScene(buildIndex:1);
}
}*/