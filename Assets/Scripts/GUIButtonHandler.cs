using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class GUIButtonHandler : MonoBehaviour
{

    public GameObject menu;
    private bool sceneLoaded = false;
    private bool gamePaused = false;

    public void enterGame() {
        //load level 1
        //want canvas to populate to the new level
        if(!sceneLoaded) {
            DontDestroyOnLoad(this.gameObject);
            DontDestroyOnLoad(GameObject.Find("EventSystem"));
            menu.SetActive(false);
            SceneManager.LoadScene("SampleScene");
            sceneLoaded = true;
        }
        else {
            menu.SetActive(false);
            Time.timeScale = 1;
            gamePaused = false;
        }
    }
    public void exitGame() {
        //system dependent, only works on exported build
        Application.Quit();
    }
    public void Update() {
        showPauseMenu();
    }
    
    private void showPauseMenu() {
        if(Input.GetKeyDown(KeyCode.P) && sceneLoaded) {
            if (!gamePaused) {
                menu.SetActive(true);
                GameObject.Find("buttonEnter").GetComponentInChildren<TextMeshProUGUI>().text = "Resume";
                Time.timeScale = 0;
                gamePaused = true;
            }
            else {
                menu.SetActive(false);
                Time.timeScale = 1;
                gamePaused = false;
            }

        }
    }
}
