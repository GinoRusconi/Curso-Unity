using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManagerNivel1 : MonoBehaviour
{
    public int _EnemigosQueDebenMorir = 1;
    EnemyManager enemyManagment;
    public int nextLvl;
    Player _player;
    private void Awake()
    {
        GameObject _EnemyManagment = GameObject.Find("EnemyManager");
        enemyManagment = _EnemyManagment.GetComponent<EnemyManager>();

        GameObject playerTank = GameObject.Find("TankJugador");
        _player = playerTank.GetComponent<Player>();
    }

    private void Update()
    {
        if (enemyManagment._EnemyMuertos >= _EnemigosQueDebenMorir)
        {
            SceneManager.LoadScene(nextLvl);
        }else if (_player._PlayerIsDead)
        {
            PlayerDead();
        }


    }

    public void PlayerDead()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
