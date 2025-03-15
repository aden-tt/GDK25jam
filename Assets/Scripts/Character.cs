using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class Character : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] private int charisma;
    [SerializeField] private int dexterity;

    [Header("Relationship")]
    [SerializeField] private int relationshipScore;
    [SerializeField] private int relationshipLevel;

    [Header("Sprite")]
    public Image portrait;
    [SerializeField] private Sprite[] expressions;

    // sets character sprite to {expressionName}
    [YarnCommand("expression")]
    public void SetExpression(string expressionName)
    {
        Sprite expressionToUse = null;
        foreach (Sprite expression in expressions)
        {
            if (expression.name == expressionName)
            {
                expressionToUse = expression;
                break;
            }
        }

        portrait.sprite = expressionToUse;
    }

    // adds/subtracts points to the relationship score
    [YarnCommand("add_points")]
    public void AddPoints(int points)
    {
        relationshipScore += points;
    }

    [YarnCommand("test_hello")]
    public static void TestHello()
    {
        Debug.Log("HELLO!!");
    }
}
