using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    [SerializeField] GameObject confirmationPanel;
    [SerializeField] public GameObject submitButton;
    [SerializeField] public GameObject returnConfirmation;
    [SerializeField] public GameObject tutorialPanel;

    public UnityAction GoCheckPuzzle;

    public void OnSubmitButton()
    {
        confirmationPanel.SetActive(true);
    }

    public void OnPuzzleCheckButton() 
    {
        GoCheckPuzzle?.Invoke();
    }

    public void OnReturnPuzzleButton()
    {
        if (confirmationPanel.activeSelf)
        {
            confirmationPanel.SetActive(false);
        }

        if (returnConfirmation.activeSelf)
        {
            returnConfirmation.SetActive(false);
        }
        
    }

    public void OnSelectPuzzleButton()
    {
        SceneManager.LoadScene("SelectScene");
    }

    public void OnRetryButton()
    {
        SceneManager.LoadScene("PuzzleScene");
    }

    public void OnNextPuzzleButton()
    {
        if(GameManager.currentPuzzleNo != 9)
        {
            GameManager.currentPuzzleNo++;
            SceneManager.LoadScene("PuzzleScene");
        }
    }

    public void OnMenuButton()
    {
        returnConfirmation.SetActive(true);
    }

    public void DisplaySubmitCheck(PieceAreaContent pieceAreaContent)
    {
        if (pieceAreaContent.transform.childCount == 0)
        {
            if (!submitButton.activeSelf)
            {
                submitButton.SetActive(true);
            }
        }
        else
        {
            if (submitButton.activeSelf)
            {
                submitButton.SetActive(false);
            }
        }
    }

    public void OnCloseTutorialButton()
    {
        tutorialPanel.SetActive(false);
    }
}
