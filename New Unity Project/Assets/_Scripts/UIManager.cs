﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text castle1HP;
    public Text castle2HP;

    // Start is called before the first frame update
    void Start()
    {
        castle1HP.text = "5";
        castle2HP.text = "5";
    }

    // Update is called once per frame
    void Update()
    {
        if (castle1HP.text == "0")
        {

        }

        if (castle2HP.text == "0")
        {

        }
    }

    public void UpdateHP(int p1HP, int p2HP)
    {
        castle1HP.text = p1HP.ToString();
        castle2HP.text = p2HP.ToString();
    }
}
