using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Mainmenue : MonoBehaviour {
    public Slider mySlider;
public void GameStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
       // Debug.Log("Quit");
        Application.Quit();
    }
    public void MainMenue()
    {
        SceneManager.LoadScene("Start Menue");
    }
    public void PlayAgainFromEnd()
    {
        SceneManager.LoadScene("L1");
    }
    public void OnValueChanged()
    {
        AudioListener.volume = mySlider.value;
    }
}
