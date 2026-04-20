using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int currentPuzzleNo;
    public static int progressStageData;
    private StartManager startManager;
    private SelectManager selectManager;

    private void Awake()
    {
        progressStageData = PlayerPrefs.GetInt("stageData");
    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "StartScene")
        {
            GameObject startManagerObj = GameObject.FindWithTag("StartManager");
            startManager = startManagerObj.GetComponent<StartManager>();
            startManager.OnStart = GameStartAction;
        }
        if (SceneManager.GetActiveScene().name == "SelectScene")
        {
            GameObject selectManagerObj = GameObject.FindWithTag("SelectManager");
            selectManager = selectManagerObj.GetComponent<SelectManager>();
            selectManager.startPuzzle = PuzzleStartAction;
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log("ƒNƒŠƒbƒN‚µ‚½: " + hit.collider.gameObject.name);
                Debug.Log(hit.collider.gameObject.layer);
            }
        }
    }

    private void GameStartAction(StartManager startManager)
    {
        SceneManager.LoadScene("SelectScene");
    }

    private void PuzzleStartAction(int puzzleNo)
    {
        currentPuzzleNo = puzzleNo;
        SceneManager.LoadScene("PuzzleScene");
    }
}
