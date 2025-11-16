using Unity.VisualScripting;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    private bool inPause;

   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if(!inPause)
            {
                PausePanel.SetActive(true);
                inPause = true;
                Time.timeScale = 0;
            }
            else
            {

                PausePanel.SetActive(false);
                inPause = false;
                Time.timeScale = 1;
            }
        }
    }
    public void pauseMenu() 
    {
        PausePanel.SetActive(false);
        inPause = false;
        Time.timeScale = 1;
        Debug.Log("Boton pulsado");
    }
    public void exitGame() 
    { 
        Application.Quit();
    }
}