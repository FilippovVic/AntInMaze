using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button _soundButton;
    [SerializeField] private Sprite _soundOff;
    [SerializeField] private Sprite _soundOn;
    [SerializeField] private GameObject _map;
    [SerializeField] private GameObject _cancelButton;
    [SerializeField] private AudioSource _sound;
    [SerializeField] private Button[] _levelButtons;
    [SerializeField] private Sprite _locked;
    [SerializeField] private Sprite _unlocked;
    [SerializeField] private Sprite _star;

    private bool _soundState = false;

    [DllImport("__Internal")]
    private static extern void ShowAdv();

    private void FixedUpdate()
    {
        if (AudioListener.volume == 0)
        {
            _soundButton.GetComponent<Image>().sprite = _soundOff;
            _soundState = true;
        } else
        {
            _soundButton.GetComponent<Image>().sprite = _soundOn;
            _soundState = false;
        }
    }

    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Level" + PlayerPrefs.GetInt("lastLevel", 1));
    }
    public void OnPlayButtonClick()
    {
        _sound.Play();
        StartCoroutine(Waiter());
    }

    public void OnSoundButtonClick()
    {
        if (!_soundState)
        {
            _soundButton.GetComponent<Image>().sprite = _soundOff;
            _soundState = true;
            AudioListener.volume = 0;
        } 
        else
        {
            _soundButton.GetComponent<Image>().sprite = _soundOn;
            _soundState = false;
            AudioListener.volume = 1;
        }
    }

    public void OnLevelsButton()
    {
/*        ShowAdv();*/
        _map.SetActive(true);

        int i = 1;
        Image img;

        foreach (Button component in _levelButtons)
        {

            if (PlayerPrefs.GetInt("level " + i, 0) == 3)
            {
                foreach (Image component1 in component.GetComponentsInChildren<Image>())
                {
                    if (component1.name == "Lock")
                    {
                        component1.GetComponent<Image>().sprite = _unlocked;
                    }
                    else if (component1.name == "Star 1")
                    {
                        component1.GetComponent<Image>().sprite = _star;
                        img = component1.GetComponent<Image>();
                        var tempColor = img.color;
                        tempColor.a = 255f;
                        img.color = tempColor;
                    }
                    else if (component1.name == "Star 2")
                    {
                        component1.GetComponent<Image>().sprite = _star;
                        img = component1.GetComponent<Image>();
                        var tempColor = img.color;
                        tempColor.a = 255f;
                        img.color = tempColor;
                    }
                    else if (component1.name == "Star 3")
                    {
                        component1.GetComponent<Image>().sprite = _star;
                        img = component1.GetComponent<Image>();
                        var tempColor = img.color;
                        tempColor.a = 255f;
                        img.color = tempColor;
                    }
                }
            }
            else if (PlayerPrefs.GetInt("level " + i, 0) == 2)
            {
                foreach (Image component1 in component.GetComponentsInChildren<Image>())
                {
                    if (component1.name == "Lock")
                    {
                        component1.GetComponent<Image>().sprite = _unlocked;
                    }
                    else if (component1.name == "Star 1")
                    {
                        component1.GetComponent<Image>().sprite = _star;
                        img = component1.GetComponent<Image>();
                        var tempColor = img.color;
                        tempColor.a = 255f;
                        img.color = tempColor;
                    }
                    else if (component1.name == "Star 2")
                    {
                        component1.GetComponent<Image>().sprite = _star;
                        img = component1.GetComponent<Image>();
                        var tempColor = img.color;
                        tempColor.a = 255f;
                        img.color = tempColor;
                    }
                    else if (component1.name == "Star 3")
                    {
                        component1.GetComponent<Image>().sprite = null;
                        img = component1.GetComponent<Image>();
                        var tempColor = img.color;
                        tempColor.a = 0f;
                        img.color = tempColor;
                    }
                }
            }
            else if (PlayerPrefs.GetInt("level " + i, 0) == 1)
            {
                foreach (Image component1 in component.GetComponentsInChildren<Image>())
                {
                    if (component1.name == "Lock")
                    {
                        component1.GetComponent<Image>().sprite = _unlocked;
                    }
                    else if (component1.name == "Star 1")
                    {
                        component1.GetComponent<Image>().sprite = _star;
                        img = component1.GetComponent<Image>();
                        var tempColor = img.color;
                        tempColor.a = 255f;
                        img.color = tempColor;
                    }
                    else if (component1.name == "Star 2")
                    {
                        component1.GetComponent<Image>().sprite = null;
                        img = component1.GetComponent<Image>();
                        var tempColor = img.color;
                        tempColor.a = 0f;
                        img.color = tempColor;
                    }
                    else if (component1.name == "Star 3")
                    {
                        component1.GetComponent<Image>().sprite = null;
                        img = component1.GetComponent<Image>();
                        var tempColor = img.color;
                        tempColor.a = 0f;
                        img.color = tempColor;
                    }
                }
            }
            else
            {
                foreach (Image component1 in component.GetComponentsInChildren<Image>())
                {
                    if (component1.name == "Lock")
                    {
                        component1.GetComponent<Image>().sprite = _locked;
                    }
                    else if (component1.name == "Star 1")
                    {
                        component1.GetComponent<Image>().sprite = null;
                        img = component1.GetComponent<Image>();
                        var tempColor = img.color;
                        tempColor.a = 0f;
                        img.color = tempColor;
                    }
                    else if (component1.name == "Star 2")
                    {
                        component1.GetComponent<Image>().sprite = null;
                        img = component1.GetComponent<Image>();
                        var tempColor = img.color;
                        tempColor.a = 0f;
                        img.color = tempColor;
                    }
                    else if (component1.name == "Star 3")
                    {
                        component1.GetComponent<Image>().sprite = null;
                        img = component1.GetComponent<Image>();
                        var tempColor = img.color;
                        tempColor.a = 0f;
                        img.color = tempColor;
                    }

                    if (PlayerPrefs.GetInt("lastLevel", 1) == i && component1.name == "Lock")
                    {
                        component1.GetComponent<Image>().sprite = _unlocked;
                    }
                }
            }
            i++;
        }
    }

    public void OnCancelButton()
    {
        _map.SetActive(false);
        ShowAdv();
    }
}