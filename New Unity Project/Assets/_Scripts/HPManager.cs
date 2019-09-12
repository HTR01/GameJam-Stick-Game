using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPManager : MonoBehaviour
{
    public int castle1HP;
    public int castle2HP;
    private UIManager uiMan;

    // Start is called before the first frame update
    void Start()
    {
        uiMan = GetComponent<UIManager>();
    }

    public void Castle1HP()
    {
        castle1HP--;
        uiMan.UpdateHP(castle1HP, castle2HP);
    }

    public void Castle2HP()
    {
        castle2HP--;
        uiMan.UpdateHP(castle1HP, castle2HP);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
