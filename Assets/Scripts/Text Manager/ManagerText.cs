using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ManagerText : MonoBehaviour
{
    public List<string> Texts = new List<string>();

    public TextMeshProUGUI textUi;
    public Image images;
    private int index = 0;

    private void Start()
    {
        textUi.text = Texts[index];
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            index++;
            if (index > Texts.Count - 1)
            {
                images.gameObject.SetActive(false);
                index = 0;
            }
            else
            {
                textUi.text = Texts[index];
            }
        }
    }
}
