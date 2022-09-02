using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Spawner : MonoBehaviour
{
    [SerializeField] Transform playerCar, npc, npc_H; //H stands for Hostile
    Vector2 spawnPos;
    Vector2[] spawnList;
    [SerializeField] float offset;
    bool isInvoked;
    private void Awake()
    {
        playerCar = GameObject.FindWithTag("Player").GetComponent<Transform>();
        //npc = GameObject.FindWithTag("NPC").GetComponent<Transform>();
        //npc_H = GameObject.FindWithTag("NPC_H").GetComponent<Transform>();
        spawnList = new Vector2[4];
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isInvoked == false)
        {
            isInvoked = true;
            Invoke("RandomPosSpawn", 2f);
        }
    }

    void RandomPosSpawn()
    {
        
        offset = playerCar.position.y + 15f;
        spawnList[0] = new Vector2(-3.2f, offset);
        spawnList[1] = new Vector2(-1f, offset);
        spawnList[2] = new Vector2(1f, offset);
        spawnList[3] = new Vector2(3.2f, offset);
        spawnPos = spawnList[Random.Range(0, 4)];
        Instantiate(npc, spawnPos, Quaternion.identity);
        isInvoked = false;
    }
}
