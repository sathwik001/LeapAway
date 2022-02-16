using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void RetryPressed()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameScene");
        
    }
}
