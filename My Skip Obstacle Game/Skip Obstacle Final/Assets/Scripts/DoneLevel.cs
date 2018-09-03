using UnityEngine;
using UnityEngine.SceneManagement;
public class DoneLevel : MonoBehaviour {
public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
