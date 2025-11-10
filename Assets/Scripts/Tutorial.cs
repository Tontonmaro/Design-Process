using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tutorial : MonoBehaviour
{
    [SerializeField] CanvasGroup tutorialPanel;
    [SerializeField] GameObject tutorialPanelObj;
    [SerializeField] MusicPlayer player;
    [SerializeField] ItemSelect select;

    public bool inTutorial = true;
    public void closeTut()
    {
        tutorialPanel.DOFade(0f, 0.2f)
            .OnComplete(() => tutorialPanelObj.SetActive(false));
        Cursor.lockState = CursorLockMode.Locked;
        inTutorial = false;
        player.tutorial = true;
        select.inMenu = false;
    }

    public void openTut()
    {
        tutorialPanelObj.SetActive(true);
        tutorialPanel.DOFade(1f, 0.2f);
        Cursor.lockState = CursorLockMode.None;
        inTutorial = true;
        select.inMenu = true;
    }

    private void Update()
    {
        if (inTutorial)
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                closeTut();
            }
        }
    }
}
