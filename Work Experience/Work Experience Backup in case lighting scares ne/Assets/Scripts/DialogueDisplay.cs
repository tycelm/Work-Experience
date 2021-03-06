﻿using UnityEngine;

public class DialogueDisplay : MonoBehaviour
{
    public Conversations conversation;

    public GameObject speakerLeft;
    public GameObject speakerRight;
    public GameObject player;
    private CharacterController2D myPlayer;
    private SpeakerUI speakerUILeft;
    private SpeakerUI speakerUIRight;

    private int activeLineIndex = 0;

    void Start()
    {
        speakerUILeft = speakerLeft.GetComponent<SpeakerUI>();
        speakerUIRight = speakerRight.GetComponent<SpeakerUI>();
        
        speakerUILeft.Speaker = conversation.speakerLeft;
        speakerUIRight.Speaker = conversation.speakerRight;

        myPlayer = player.GetComponent<CharacterController2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            AdvanceConversation();
        }
    }
    
    void AdvanceConversation()
    {
        if(activeLineIndex < conversation.lines.Length)
        {
            myPlayer.canMove = false;
            DisplayLine();
            activeLineIndex += 1;
        }
        else
        {
            speakerUILeft.Hide();
            speakerUIRight.Hide();
            activeLineIndex = conversation.lines.Length - 1;
            myPlayer.canMove = true;
        }

        void DisplayLine()
        {
            Line line = conversation.lines[activeLineIndex];
            Character character = line.character;

            if(speakerUILeft.SpeakerIs(character))
            {
                SetDialog(speakerUILeft, speakerUIRight, line.text);
            }
            else
            {
                SetDialog(speakerUIRight, speakerUILeft, line.text);
            }

            void SetDialog(SpeakerUI activeSpeakerUI, SpeakerUI inactiveSpeakerUI, string text)
            {
                activeSpeakerUI.Dialog = text;
                activeSpeakerUI.Show();
                inactiveSpeakerUI.Hide();
            }
        }
    }
}
