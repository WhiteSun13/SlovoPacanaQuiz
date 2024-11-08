using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultPanel : MonoBehaviour
{
    public Text RightOrNo;
    public Text QuestAnsw;
    
    private Image Back;
    Color someColor = new Color(0f, 0.75f, 0f, 1.0f);

    // Start is called before the first frame update
    void Awake()
    {
        Back = GetComponent<Image>();
    }

    public void SetAnsw(bool Corr, string TrueAnsw, string UserAnsw)
    {
        if (Corr)
        {
            Back.color = someColor;
            RightOrNo.text = "Верно!";
            QuestAnsw.text = "Ваш ответ: " + UserAnsw;
        }
        else
        {
            Back.color = Color.red;
            RightOrNo.text = "Не верно!";
            QuestAnsw.text = "Верный ответ: " + TrueAnsw + "\nВаш ответ: " + UserAnsw;
        }
    }
}
