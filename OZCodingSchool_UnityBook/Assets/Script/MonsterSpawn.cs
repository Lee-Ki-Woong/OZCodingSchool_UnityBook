using UnityEngine;

public class MonsterSpawn : MonoBehaviour
{
    [SerializeField] private Transform MonsterSpawnPoint;
    [SerializeField] private GameObject MonsterPref;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            StartMonsterSpawn();
        }
    }

    private void StartMonsterSpawn()
    {
        if (MonsterSpawnPoint != null && MonsterPref != null)
        {
            Instantiate(MonsterPref, MonsterSpawnPoint.position, Quaternion.identity);
        }
    }
}
