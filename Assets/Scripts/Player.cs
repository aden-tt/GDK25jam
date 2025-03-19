using UnityEngine;
using Yarn.Unity;

public class Player : MonoBehaviour
{
    [Header("Stats")]
    public int charisma;
    public int intelligence;
    public int dexterity;

    [Header("Role")]
    [SerializeField] private string role;

    [Header("Skill Checks Attempts")]
    [SerializeField] private int fails;


    public void setRole(string role) 
    {  
        this.role = role; 
    }

    // <<skill_check Player charisma 8>>
    [YarnCommand("skill_check")]
    public bool SkillCheck(string skill, int threshold)
    {
        // get player skill stat
        
        // roll dice

        // calculate skill + dice

        // return true if passes threshold

        // return false if not

        return true;
    }

}
