using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Waypoint
{

    [TextArea(1, 5)]
    public string x;
    [TextArea(1, 5)]
    public string y;
}

[CreateAssetMenu(fileName = "New PatrolLayout", menuName = "Patrol")]
public class PatrolPath : ScriptableObject
{
    public Waypoint[] Waypoints;
}
