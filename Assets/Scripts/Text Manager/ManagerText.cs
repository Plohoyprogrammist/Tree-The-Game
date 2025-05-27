using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ManagerText : MonoBehaviour
{
    public List<string> Texts = new List<string>();
    public List<string> dialogText = new List<string>();

    public TextMeshProUGUI textUi;
    public Image images;
    private int index = 0;

    private bool isEnd = false;

    private void Start()
    {
        textUi.text = Texts[index];
    }

    private void Update()
    {
        if (isEnd == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                index++;
                if (index > Texts.Count - 1)
                {
                    images.gameObject.SetActive(false);
                    index = 0;
                    isEnd = true;
                }
                else
                {
                    textUi.text = Texts[index];
                }
            }
        }
    }

    public void Dialoge(int[] indexs)
    {
        bool isNotEndDialoge = true;
        int countIndex = 0;
        images.gameObject.SetActive(true);

        while (isNotEndDialoge)
        {
            textUi.text = dialogText[indexs[countIndex]];
            if (countIndex < indexs.Length)
            {
                if (Input.GetMouseButtonDown(0)) { countIndex++; }
            }
            else
            {
                isNotEndDialoge = false;
            }
        }
        textUi.text = null;
        images.gameObject.SetActive(true);
    }
}
