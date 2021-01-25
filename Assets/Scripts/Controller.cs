using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    [SerializeField] private Image[] Objects = default;

    int currentIndex = 0;

    public void Switch(bool isNext)
    {
        UpdateFlare(currentIndex + (isNext ? 1 : -1));
    }

    public void Switch(int index)
    {
        UpdateFlare(index);
    }

    private void UpdateFlare(int index)
    {
        Objects[currentIndex].enabled = false;
        currentIndex = Mathf.Clamp(index, 0, Objects.Length-1);
        Objects[currentIndex].enabled = true;
    }
}
