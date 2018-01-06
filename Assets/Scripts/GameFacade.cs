using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFacade : MonoBehaviour
{
    private static GameFacade instance;
    public static GameFacade GetInstance()
    {
        if (instance == null)
        {
            instance = GameObject.FindObjectOfType<GameFacade>();
            if(instance == null)
            {
                throw new System.Exception("GameFacade不存在於場景中，請在場景中添加");
            }
            instance.Initialize();
        }
        return instance;
    }

    public StageData[] stageDatas;
    public LevelData levelData;
    public PlayerData playerData;
    public GameStateData gameStateData;
    private void Initialize()
    {
        playerData = new PlayerData();
        gameStateData = new GameStateData();
    }
    private void Awake() {
        GetInstance();
    }
}
