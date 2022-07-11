using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        string path = Application.persistentDataPath + "/player.pog";
        FileStream stream = new FileStream(path, FileMode.Create);
        stream.Dispose();

        SceneManager.LoadScene(1,LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        SceneManager.LoadScene(data.level);
    }
}
 