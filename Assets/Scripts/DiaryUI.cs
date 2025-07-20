using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryUI : MonoBehaviour
{
    public float counter =2f;

    private void Update()
    {
        counter -= Time.deltaTime;

        if (counter < 0)
        {
            if (Input.anyKeyDown)
            {
                CloseUI();
            }
        }
        

    }

    public void CloseUI()
    {
        gameObject.SetActive(false);
    }
}
