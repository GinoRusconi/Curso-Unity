using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManagerNivel1 : MonoBehaviour
{
    public int _EnemigosQueDebenMorir = 1;
    EnemyManager enemyManagment;
    public int nextLvl;

    private void Awake()
    {
        GameObject _EnemyManagment = GameObject.Find("EnemyManager");
        enemyManagment = _EnemyManagment.GetComponent<EnemyManager>();
    }

    private void Update()
    {
        if (enemyManagment._EnemyMuertos >= _EnemigosQueDebenMorir)
        {
            SceneManager.LoadScene(nextLvl);
        }
    }
}
