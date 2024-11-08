using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    public Sprite[] sprites; // Массив спрайтов

    void Start()
    {
        SetImg(0);
    }

    public void SetImg(int id)
    {
        Image img = GetComponent<Image>();
        img.sprite = sprites[id]; // Изменение спрайта
    }
}