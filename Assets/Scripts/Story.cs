using System.Collections;
using UnityEngine;
using Yarn.Unity;  


// Controls the story progression - i.e., scheduling of events and scripts for each day
public class Story : MonoBehaviour
{
    [Header("Dependencies")]
    [SerializeField] private GameObject player;
    [SerializeField] private DialogueRunner dialogueRunner;
    [SerializeField] private RoleSelect roleSelect;
    [SerializeField] private NightUI nightUI;
    private UIController uiController;


    [Header("Game Variables")]
    public int fails; // skill check fails

    [Header("Story Options")]
    public bool endingOne;
    public bool endingTwo;

    

    private enum Chapter
    {
        ChapterOne,
        ChapterTwo,
        ChapterThree,
        Ending
    }

    private Chapter chapter;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        uiController = GetComponent<UIController>();
        uiController.HideUI(uiController.portraits);
        uiController.HideUI(uiController.dialogueUI);

        nightUI.OnEndNight += ExitNightPhase;

        AddYarnCommands();

        StartCoroutine(NewGame());
    }

    private void Update()
    {
        // if player fails two attempts in a row, progress to next day
        if (fails == 2)
        {
            ProgressChapter();
        }
    }

    void AddYarnCommands()
    {
        dialogueRunner.AddCommandHandler("end_day", EnterNightPhase);
    }

    // Handle role selection and loading the first chapter
    IEnumerator NewGame()
    {
        yield return StartCoroutine(roleSelect.WaitForRoleSelection()); // Wait until role selection is done

        chapter = Chapter.ChapterOne;
        uiController.ShowDayUI();
        LoadChapter();
    }

    void LoadChapter ()
    {
        switch (chapter)
        {
            case Chapter.ChapterOne:
                ChapterOne();
                break;
            case Chapter.ChapterTwo:
                ChapterTwo();
                break;
            case Chapter.ChapterThree:
                ChapterThree();
                break;
            case Chapter.Ending:
                Ending();
                break;
        }
    }

    // Goes to next chapter and loads it
    void ProgressChapter()
    {
        switch (chapter)
        {
            case Chapter.ChapterOne:
                chapter = Chapter.ChapterTwo;
                break;
            case Chapter.ChapterTwo:
                chapter = Chapter.ChapterThree;
                break;
            case Chapter.ChapterThree:
                chapter = Chapter.Ending;
                break;
        }
        LoadChapter();
    }

    public void EnterNightPhase()
    {
        uiController.HideDayUI();
        uiController.ShowNightUI();
    }

    public void ExitNightPhase()
    {
        uiController.HideNightUI();
        uiController.ShowDayUI();
        ProgressChapter();
    }

    void ChapterOne()
    {
        dialogueRunner.StartDialogue("ChapterOneStart");
    }
    void ChapterTwo()
    {
        dialogueRunner.StartDialogue("ChapterTwoStart");
    }

    void ChapterThree()
    {
        dialogueRunner.StartDialogue("ChapterThreeStart");
    }

    void Ending()
    {
        if (endingOne)
            dialogueRunner.StartDialogue("endingOne");
        else if (endingTwo)
            dialogueRunner.StartDialogue("endingTwo");

    }
}
