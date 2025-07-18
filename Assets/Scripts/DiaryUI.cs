using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryUI : MonoBehaviour
{
    private void Update()
    {
        if (Input.anyKeyDown)
        {
            CloseUI();
        }
    }

    public void CloseUI()
    {
        gameObject.SetActive(false);
    }
}
