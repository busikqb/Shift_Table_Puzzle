using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class StartManager : MonoBehaviour
{
    [SerializeField] GameObject deleteConfirmationPanel;
    [SerializeField] GameObject deleteConfirmationButton;

    public UnityAction<StartManager> OnStart;

    public void OnStartButton()
    {
        OnStart?.Invoke(this);
    }

    public void OnDeleteConfirmationButton()
    {
        deleteConfirmationPanel.SetActive(true);
        deleteConfirmationButton.SetActive(false);
    }

    public void OnDeleteButton()
    {
        PlayerPrefs.DeleteKey("stageData");
        deleteConfirmationPanel.SetActive(false);
        deleteConfirmationButton.SetActive(true);
    }

    public void OnCloseDeleteConfirmationButton()
    {
        deleteConfirmationPanel.SetActive(false);
        deleteConfirmationButton.SetActive(true);
    }
}
