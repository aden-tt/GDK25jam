using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class DialogueController : MonoBehaviour
{
    [Header("Dialogue System")]
    [SerializeField] private DialogueRunner dialogueRunner;

    [Header("Dialogue System UI")]
    [SerializeField] private GameObject canvas;
    [SerializeField] private Image portrait;


    public void ShowPortrait()
    {
        portrait.gameObject.SetActive(true);
    }

    public void HidePortrait()
    {
        portrait.gameObject.SetActive(false);
    }

    public void HideDialogueBox()
    {
        canvas.SetActive(false);
    }

    public void ShowDialogueBox()
    {
        canvas.SetActive(true);
    }

    public void StartDialogue(string startNode)
    {
        dialogueRunner.StartDialogue(startNode);
    }
}
