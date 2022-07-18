using UnityEngine.SceneManagement;
using UnityEngine;


public class GameManagerNivel3 : MonoBehaviour
{
    public int _EnemigosQueDebenMorir = 1;
    EnemyManager enemyManagment;
    public int _TimeSurvival;
    TimeManager _TimeManager;
    
    public int nextLvl;

    void Awake()
    {
        GameObject _EnemyManagment = GameObject.Find("EnemyManager");
        enemyManagment = _EnemyManagment.GetComponent<EnemyManager>();

        GameObject _timeManager = GameObject.Find("TimeManager");
        _TimeManager = _timeManager.GetComponent<TimeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_TimeManager._TiempoDesdeAwake >= _TimeSurvival)
        {
            if (enemyManagment._EnemyMuertos >= _EnemigosQueDebenMorir)
            {
                SceneManager.LoadScene(nextLvl);
            }
        }
    }
    
}
