using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int questID = 0;
    public static int correctCount = 0;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
