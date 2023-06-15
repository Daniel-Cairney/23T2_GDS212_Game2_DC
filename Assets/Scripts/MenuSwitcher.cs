using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuSwitcher : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void StartScene()
    {
        SceneManager.LoadScene("StartScene");
    }

    private void FoundFriend()
    {
        SceneManager.LoadScene("FoundFriend");
    }

    public void DeadFriend()
    {
        SceneManager.LoadScene("DeadFriend");
    }

    public void MonsterDeath()
    {
        SceneManager.LoadScene("MonsterDeath");
    }

    public void LostEnd()
    {
        SceneManager.LoadScene("LostEnd");
    }

   
}
