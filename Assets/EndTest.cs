using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndTest : MonoBehaviour
{
    public Text EndGameText;

    // Start is called before the first frame update
    void Start()
    {
        EndGameText.text = "Ваш результат: " + GameManager.correctCount.ToString() + "/" + 100;
    }

    public void ExitMenu()
    {
        SceneManager.LoadScene(0);
    }
}
