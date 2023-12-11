using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsDisplay : MonoBehaviour
{
    public Button creditsButton;
    public Button startButton;
    public GameObject titleText;

    public GameObject creditsTitle;
    public GameObject creatorsList;
    public Button returnMain;
    
    public void ClickStart()
    {
        if (creditsButton != null)
        {
            creditsButton.gameObject.SetActive(false);
        }

        if (startButton != null)
        {
            startButton.gameObject.SetActive(false); 
        }

        if (titleText != null)
        {
            titleText.SetActive(false); 
        }

        if (creditsTitle != null)
        {
            creditsTitle.gameObject.SetActive(true);  
        }

        if (creatorsList != null)
        {
            creatorsList.gameObject.SetActive(true);
        }

        if (returnMain != null)
        {
            returnMain.gameObject.SetActive(true); // goes back to main menu button
        }
       
       
    }
    
}
