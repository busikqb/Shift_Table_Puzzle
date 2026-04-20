using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SelectManager : MonoBehaviour
{
    [SerializeField] private SelectPuzzle selectButton0;
    [SerializeField] private SelectPuzzle selectButton1;
    [SerializeField] private SelectPuzzle selectButton2;
    [SerializeField] private SelectPuzzle selectButton3;
    [SerializeField] private SelectPuzzle selectButton4;
    [SerializeField] private SelectPuzzle selectButton5;
    [SerializeField] private SelectPuzzle selectButton6;  
    [SerializeField] private SelectPuzzle selectButton7;  
    [SerializeField] private SelectPuzzle selectButton8;
    [SerializeField] private SelectPuzzle selectButton9;

    public UnityAction<int> startPuzzle;

    private void Start()
    {
        SelectPuzzle[] selectButtons = { selectButton0, selectButton1, selectButton2, selectButton3, selectButton4, selectButton5, selectButton6, selectButton7, selectButton8, selectButton9};
        //現在のprogressStageDataに合わせてSelectPuzzleButtonを生成したい
        //SelectPuzzleButtonを生成するコードが欲しい
        //しかし、締め切りまでの時間が少ないので、とりあえず、ステージを10個に限定し、ボタンの表示、非表示を切り替える。

        int displayNo = GameManager.progressStageData;

        for (int i = 0; i <= displayNo; i++)
        {
            //GameObject displayButton = ボタンオブジェクトを集めたリストから番号でそのオブジェクトを持ってくる
            GameObject selectButton = selectButtons[i].gameObject;
            selectButton.gameObject.SetActive(true);
            selectButtons[i].OnSelectPuzzle = SelectPuzzleAction;
        }
    }

    private void SelectPuzzleAction(int puzzleNo)
    {
        startPuzzle?.Invoke(puzzleNo);
    }
}
