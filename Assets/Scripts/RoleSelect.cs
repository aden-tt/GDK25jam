using UnityEngine;
using UnityEngine.UI;

public class RoleSelect : MonoBehaviour
{
    public Button paladinButton;
    public Button wizardButton;
    public Button rogueButton;

    public Player player;

    public DialogueController dialogueController;

    private int classBuff = 5;

    public void setPaladin()
    {
        Debug.Log("click!");
        player.charisma += classBuff;
        player.setRole("paladin");
        BeginScene();
    }

    public void setWizard()
    {
        player.intelligence += classBuff;
        player.setRole("wizard");
        BeginScene();
    }

    public void setRogue()
    {
        player.dexterity += classBuff;
        player.setRole("rogue");
        BeginScene();
    }

    // Hides role select and begins dialogue for Day 1
    private void BeginScene()
    {
        gameObject.SetActive(false);
        dialogueController.ShowDialogueBox();
        dialogueController.ShowPortrait();
        dialogueController.StartDialogue("Start");
    }

}
