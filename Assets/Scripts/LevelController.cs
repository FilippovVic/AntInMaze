using System.Collections;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class LevelController : MonoBehaviour
{
    [SerializeField] private GameObject _timer;
    private int _level;
    private string _levelName;

    IEnumerator WaitRestart()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(_levelName);
    }

    IEnumerator WaitMainMenu()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("MainMenu");
    }

    IEnumerator WaitLoading()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Level" + _level);
    }

    public void OnRestartButton()
    {
        _levelName = SceneManager.GetActiveScene().name;
        StartCoroutine(WaitRestart());
        Destroy(_timer);
        Time.timeScale = 1.0f;
    }

    public void OnResumeButton()
    {
        _levelName = SceneManager.GetActiveScene().name;

        if (_levelName.Equals("Level1"))
        {
            _level = 2;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 1", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 1", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 1", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 2);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level2"))
        {
            _level = 3;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 2", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 2", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 2", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 3);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level3"))
        {
            _level = 4;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 3", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 3", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 3", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 4);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level4"))
        {
            _level = 5;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 4", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 4", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 4", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 5);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level5"))
        {
            _level = 6;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 5", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 5", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 5", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 6);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level6"))
        {
            _level = 7;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 6", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 6", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 6", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 7);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level7"))
        {
            _level = 8;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 7", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 7", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 7", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 8);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level8"))
        {
            _level = 9;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 8", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 8", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 8", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 9);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level9"))
        {
            _level = 10;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 9", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 9", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 9", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 10);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level10"))
        {
            _level = 11;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 10", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 10", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 10", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 11);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level11"))
        {
            _level = 12;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 11", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 11", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 11", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 12);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level12"))
        {
            _level = 13;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 12", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 12", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 12", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 13);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level13"))
        {
            _level = 14;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 13", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 13", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 13", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 14);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level14"))
        {
            _level = 15;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 14", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 14", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 14", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 15);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level15"))
        {
            _level = 16;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 15", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 15", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 15", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 16);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level16"))
        {
            _level = 17;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 16", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 16", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 16", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 17);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level17"))
        {
            _level = 18;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 17", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 17", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 17", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 18);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level18"))
        {
            _level = 19;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 18", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 18", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 18", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 19);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level19"))
        {
            _level = 20;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 19", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 19", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 19", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 20);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level20"))
        {
            _level = 21;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 20", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 20", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 20", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 21);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level21"))
        {
            _level = 22;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 21", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 21", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 21", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 22);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level22"))
        {
            _level = 23;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 22", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 22", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 22", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 23);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level23"))
        {
            _level = 24;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 23", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 23", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 23", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 24);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level24"))
        {
            _level = 25;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 24", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 24", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 24", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 25);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level25"))
        {
            _level = 26;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 25", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 25", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 25", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 26);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level26"))
        {
            _level = 27;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 26", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 26", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 26", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 27);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level27"))
        {
            _level = 28;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 27", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 27", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 27", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 28);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level28"))
        {
            _level = 29;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 28", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 28", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 28", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 29);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level29"))
        {
            _level = 30;
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 29", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 29", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 29", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 30);
            LoadNextLevel();
        }
        else if (_levelName.Equals("Level30"))
        {
            if (PlayerPrefs.GetInt("rate", 0) == 3)
            {
                PlayerPrefs.SetInt("level 30", 3);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 2)
            {
                PlayerPrefs.SetInt("level 30", 2);
            }
            else if (PlayerPrefs.GetInt("rate", 0) == 1)
            {
                PlayerPrefs.SetInt("level 30", 1);
            }
            PlayerPrefs.SetInt("lastLevel", 30);
            StartCoroutine(WaitMainMenu());
            Destroy(_timer);
            Time.timeScale = 1.0f;
        }
    }

    private void LoadNextLevel()
    {
        StartCoroutine(WaitLoading());
        Destroy(_timer);
        Time.timeScale = 1.0f;
    }

    public void OnMenuButton()
    {
        StartCoroutine(WaitMainMenu());
        Destroy(_timer);
        Time.timeScale = 1.0f;
    }
}