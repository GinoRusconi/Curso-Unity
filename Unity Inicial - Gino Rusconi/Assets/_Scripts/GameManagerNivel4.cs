using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManagerNivel4 : MonoBehaviour
{
    public int _ScoreToWin;
    public int _TimeToLose;
    private ScoreManager _scoreManager;
    private TimeManager _timeManager;

    public int _NextLvl;
    public int _SwapLvlToLose;

    private void Awake()
    {
        GameObject scoreManager = GameObject.Find("ScoreManager");
        _scoreManager = scoreManager.GetComponent<ScoreManager>();
       
        GameObject timeManager = GameObject.Find("TimeManager");
        _timeManager = timeManager.GetComponent<TimeManager>();
    }

    void Update()
    {
        if (_ScoreToWin <= _scoreManager._Score)
        {
            SceneManager.LoadScene(_NextLvl);
        }

        if (_TimeToLose <= _timeManager._TiempoDesdeAwake)
        {
            SceneManager.LoadScene(_SwapLvlToLose);
        }
    }
    public void PlayerDead()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
