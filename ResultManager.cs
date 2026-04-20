using UnityEngine;

public class ResultManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PuzzleInspector.isClose)
        {
            Debug.Log("Ÿè‚É•Â“X‚·‚é‚ñ‚¶‚á‚Ë‚¥A‚Ó‚´‚¯‚ñ‚È");
            PuzzleInspector.isClose = false;
        }

        if (PuzzleInspector.isBreachContract)
        {
            Debug.Log("‚±‚ñ‚È‚ÌŒ_–ñˆá”½‚¾‚æ");
            PuzzleInspector.isBreachContract = false;
        }

        if (PuzzleInspector.isUnderstaffed)
        {
            Debug.Log("lè‚ª‘«‚è‚È‚¢‚æ‚¤");
            PuzzleInspector.isUnderstaffed = false;
        }
    }
}
