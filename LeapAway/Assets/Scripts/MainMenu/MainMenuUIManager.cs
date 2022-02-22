using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuUIManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _highscoreText;

    private void Start()
    {
        _highscoreText.text = "H i g h S c o r e : " + PlayerPrefs.GetInt("HighScore");
    }

    public void Play()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
}
