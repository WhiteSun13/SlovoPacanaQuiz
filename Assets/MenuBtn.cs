using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBtn : MonoBehaviour
{
    public GameObject openPanel;
    public void OpenPanel()
    {
        openPanel.SetActive(true);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
}
