using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class diary : MonoBehaviour
{
    //public PlayerGrab playerGrab;
    //public Text diaryBoxText;

    public GameObject diaryPanel;
    public string diaryText;
    private bool playerInDiary;


    void Update()
    {
        if (playerInDiary)
        {
            diaryPanel.SetActive(true);
        }
        

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && other.GetType().ToString() == "UnityEngine.CapsuleCollider2D")
        {
            Debug.Log("111");
            playerInDiary = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && other.GetType().ToString() == "UnityEngine.CapsuleCollider2D")
        {
            Debug.Log("222");
            playerInDiary = false;
            diaryPanel.SetActive(false);
        }
    }






}
