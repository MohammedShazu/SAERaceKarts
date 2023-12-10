using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackToMenu : MonoBehaviour
{
    public Button returnMain;

    public GameObject creditsTitle;
    public GameObject creatorsList;

    public Button startButton;
    public Button creditsButton;
    public GameObject titleText;

    public void ClickReturnMain()
    {

        if (startButton != null)
        {
            startButton.gameObject.SetActive(true);
        }

        if (creditsButton != null)
        {
            creditsButton.gameObject.SetActive(true);
        }

        if (titleText != null)
        {
            titleText.SetActive(true);
        }

        if (returnMain != null)
        {
            returnMain.gameObject.SetActive(false);
        }

        if (creditsTitle != null)
        {
            creditsTitle.SetActive(false);
        }

        if (creatorsList != null)
        {
            creatorsList.SetActive(false);
        }
    }
}
