using UnityEngine;
using UnityEngine.UI;



[System.Serializable]
public struct Line
{
    public Character character;

    [TextArea(3, 10)]
    public string text;
}

[CreateAssetMenu(fileName = "New Conversation", menuName = "Conversations")]
public class Conversations : ScriptableObject
{
    public Character speakerLeft;
    public Character speakerRight;
    public Line[] lines;
}
