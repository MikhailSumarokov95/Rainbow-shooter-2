using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class SpawnerBots : MonoBehaviour
{
    public static List<Life> SpawnEnemies(SpawnBot[] spawnEnemy)
    {
        var enemy = new List<Life>();
        for (var i = 0; i < spawnEnemy.Length; i ++)
        {   
            var countEnemy = spawnEnemy[i].Count;
            for (var j = 0; j < countEnemy; j++)
            {
                var numberSpawnPoint = Random.Range(0, spawnEnemy[i].SpawnPoints.Length);
                var spawnPoint = spawnEnemy[i].SpawnPoints[numberSpawnPoint];
                enemy.Add(Instantiate(spawnEnemy[i].BotPrefs.gameObject, spawnPoint.position, spawnPoint.rotation)
                    .GetComponent<Life>());
            }
        }
        return enemy;
    }

    [Serializable]
    public class SpawnBot
    {
        public Life BotPrefs;
        public int Count;
        public Transform[] SpawnPoints;
    }
}