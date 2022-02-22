using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsUI : MonoBehaviour
{
    [SerializeField]
    private Image _soundOn, _soundOff;
    private bool muted = false;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
        else
        {
            Load();
        }
        UpdateIcon();
        AudioListener.pause = muted;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    private void UpdateIcon()
    {
        if(muted == false)
        {
            _soundOn.enabled = true;
            _soundOff.enabled = false;
        }
        else
        {
            _soundOn.enabled = false;
            _soundOff.enabled = true;
        }
    }

    public void OnButtonClicked()
    {
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }
        else
        {
            muted = false;
            AudioListener.pause = false;
        }

        Save();
        UpdateIcon();
    }

    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }

    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }

    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
