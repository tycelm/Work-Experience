using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpeakerUI : MonoBehaviour
{
   public Image portrait;
   public TextMeshProUGUI dialog;

   private Character speaker;
   public Character Speaker
   {
       get {return speaker;}
       set{
           speaker = value;
           portrait.sprite = speaker.portrait;
       }
   }

   public string Dialog
   {
       set { dialog.text = value; }
       get { return dialog.text; }
   }

   public bool HasSpeaker()
   {
       return speaker != null;
   }

   public bool SpeakerIs(Character character)
   {
       return speaker == character;
   }

   public void Show()
   {
       gameObject.SetActive(true);
   }

   public void Hide()
   {
       gameObject.SetActive(false);
   }
}
