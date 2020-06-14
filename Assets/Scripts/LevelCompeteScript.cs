using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelCompeteScript : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
