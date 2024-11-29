/*******************************************************************************************
    Visual Novel, GDDV107 - Alexander "AJ" Fraser, Lisa Zhu, Jyden Briones

    The purpose of this script is to manage the main menu, and the actions that happen when 
    you press the buttons.

    Methods:
    StartGame - Loads the main game scene.
    OpenHowToPlay - Opens the tutorial panel.
    CloseHowToPlay - Closes tutorial panel, returns back to main menu.
    OpenSettings - Opens the settings panel.
    CloseSettings - Closes settings panel, returns back to main menu.
    OpenCredits - Opens the credits panel.
    CloseCredits - Closes credits panel, returns back to main menu.
    QuitGame - Closes application
********************************************************************************************/

using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [Header("Panels")]
    public GameObject howToPlayPanel;
    public GameObject settingsPanel;
    public GameObject creditsPanel;

    public GameObject Interview;
    public GameObject Begin;

    public bool transition; 
    public bool transitionout; 



    //Start Game
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    //Tutorial Instructions
    public void OpenHowToPlay()
    {
        howToPlayPanel.SetActive(true);
    }

    public void CloseHowToPlay()
    {
        howToPlayPanel.SetActive(false);
    }

    //Game Settings
    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
    }

    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
    }

    //Credits
    public void OpenCredits()
    {
        creditsPanel.SetActive(true);
    }

    public void CloseCredits()
    {
        creditsPanel.SetActive(false);
    }

    //Quit
    public void QuitGame()
    {
        Application.Quit();
    }

    public void InterrogationTransition()
    {
        transition = true;
    }

     public void DeInterrogationTransition()
    {
        transitionout = true;
    }

    void Update(){
        if (transition==true){
            Begin.transform.Translate(Vector3.right * 15 * Time.deltaTime);
            Interview.transform.Translate(Vector3.left * 15 * Time.deltaTime);
            if (Begin.transform.position.x > 0) {
                transition=false;
            }
        }
        if (transitionout==true){
            Begin.transform.Translate(Vector3.down * 15 * Time.deltaTime);
            Interview.transform.Translate(Vector3.up * 15 * Time.deltaTime);
            if (Begin.transform.position.y < -10) {
                transitionout=false;
                Interview.transform.position = new Vector3(15f, 2.41f, -2.640564f);
                Begin.transform.position = new Vector3(-15f, 0.9852f, -2.640564f);
            }
        }
    }
}
