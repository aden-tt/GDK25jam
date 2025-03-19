using UnityEngine;

public class DayOne : MonoBehaviour
{
    private DialogueController controller;

    void Start()
    {
        controller = GetComponent<DialogueController>();

        // Hide Dialogue while player chooses a role
        controller.HideDialogueBox();
    }


}
