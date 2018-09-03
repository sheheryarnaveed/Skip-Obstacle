
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {

    bool GameHasEnded = false;
    public float restartdelay = 2f;
    public GameObject levelcompletestatement ;
    public void completeL1UI()
    {
        levelcompletestatement.SetActive(true);
    }
    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Invoke("Restart", restartdelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
