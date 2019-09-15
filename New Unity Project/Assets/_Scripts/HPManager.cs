using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPManager : MonoBehaviour
{
    public int castle1HP;
    public int castle2HP;
    private UIManager uiMan;
    public GameObject Win1;
    public GameObject Win2;

    // Start is called before the first frame update
    void Start()
    {
        uiMan = GetComponent<UIManager>();
        Time.timeScale = 1;
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
        if (castle1HP == 0)
        {
            Win1.SetActive(true);
            Time.timeScale = 0;
            SceneManager.LoadScene(1);
        }

        if (castle2HP == 0)
        {
            Win2.SetActive(true);
            Time.timeScale = 0;
            SceneManager.LoadScene(1);
        }
    }
}
