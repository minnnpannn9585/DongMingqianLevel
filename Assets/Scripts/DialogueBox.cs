using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueBox : MonoBehaviour
{

        public GameObject dialoguePanel;
        public GameObject dialogueText;
        //public GameObject PlayerUI;

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                dialoguePanel.SetActive(true);
                dialogueText.SetActive(true);
                //PlayerUI.SetActive(false);

            }
        }
        void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {

                dialoguePanel.SetActive(false);
                dialogueText.SetActive(false);
                //PlayerUI.SetActive(true);
            }
        }


}
