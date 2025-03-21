using System;
using UnityEngine;

public class NightUI : MonoBehaviour
{
    public event Action OnEndNight;

    public void NextDay()
    {
        Debug.Log("next button clicked");
        OnEndNight.Invoke();
    }


}
