using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    public GameStateData gameStateData;
    [SerializeField]
    private Transform enemySpawnPoint;

    public void Awake() {
        gameStateData = GameFacade.GetInstance().gameStateData;
    }
    public IEnumerator Execute() {
        StageData stageData =gameStateData.CurStageData;
        for (int i = 0; i < stageData.enemys.Length; i++) { //判斷有沒有下一隻怪物
            EnemyData enemyData = stageData.enemys[i];
            EnemyBehavior enemy = Instantiate(enemyData.enemyPrefab,enemySpawnPoint.position,enemySpawnPoint.rotation);
            yield return StartCoroutine(enemy.Execute(enemyData));
            Destroy(enemy.gameObject);
        }
    }

}
