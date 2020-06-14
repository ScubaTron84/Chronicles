using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerEngine : MonoBehaviour
{

    private bool _isGameOver = false;
    private float _restartDelay = 3f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (_isGameOver == false)
        {
            _isGameOver = true;
            Debug.Log("The Game Is Over");
            Invoke("RestartGame", _restartDelay);
        }
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
