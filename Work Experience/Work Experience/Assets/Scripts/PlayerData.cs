using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int level;
    public int health;
    public float[] position;

    public PlayerData (SaveStation player)
    {
        level = player.level;

        health = player.stat.health;

        position = new float[3];
        position[0] = player.player.transform.position.x;
        position[1] = player.player.transform.position.y;
        position[2] = player.player.transform.position.z;
    }
}
