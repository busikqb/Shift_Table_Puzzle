using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SelectPuzzle : MonoBehaviour
{
    [SerializeField] private int _puzzleNo;
    public UnityAction<int> OnSelectPuzzle;

    public void OnSelectPuzzleButton()
    {
        GameManager.currentPuzzleNo = _puzzleNo;
        OnSelectPuzzle?.Invoke(_puzzleNo);
        Debug.Log($"åªç›ÇÃPuzzleNoÇÕ{GameManager.currentPuzzleNo}Ç≈Ç∑");
    }
}
