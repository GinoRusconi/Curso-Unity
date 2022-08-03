using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManagerNivel2 : MonoBehaviour
{
    public int _TimeSurvival;
    TimeManager _TimeManager;
    public int nextLvl;

    void Awake()
    {
        GameObject _timeManager = GameObject.Find("TimeManager");
        _TimeManager = _timeManager.GetComponent<TimeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_TimeManager._TiempoDesdeAwake >= _TimeSurvival)
        {
            SceneManager.LoadScene(nextLvl);
        }
    }
    public void PlayerDead()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
