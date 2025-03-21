using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public CanvasGroup dayUI;
    public CanvasGroup nightUI;
    public CanvasGroup dialogueUI;
    public CanvasGroup portraits;

    public void HideUI(CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
    }

    public void ShowUI(CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
    }


    public void HideDayUI()
    {
        HideUI(dayUI);
    }

    public void ShowDayUI()
    {
        ShowUI(dayUI);
        ShowUI(dialogueUI);
        ShowUI(portraits);
    }

    public void HideNightUI()
    {
        HideUI(nightUI);
    }

    public void ShowNightUI()
    {
        ShowUI(nightUI);
    }
}

