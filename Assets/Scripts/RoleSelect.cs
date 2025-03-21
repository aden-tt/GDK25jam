using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RoleSelect : MonoBehaviour
{
    public Button paladinButton;
    public Button wizardButton;
    public Button rogueButton;

    public Player player;

    private int classBuff = 5;

    private bool isRoleSelected;

    public IEnumerator WaitForRoleSelection()
    {
        while (isRoleSelected == false)
        {
            yield return null;
        }
        HideRoleSelect();
    }


    public void SetPaladin()
    {
        Debug.Log("click!");
        player.charisma += classBuff;
        player.setRole("paladin");
        isRoleSelected = true;
    }

    public void SetWizard()
    {
        player.intelligence += classBuff;
        player.setRole("wizard");
        isRoleSelected = true;
    }

    public void SetRogue()
    {
        player.dexterity += classBuff;
        player.setRole("rogue");
        isRoleSelected = true;
    }

    // Hides role select and begins dialogue for Day 1
    private void HideRoleSelect()
    {
        gameObject.SetActive(false);
    }

}
