using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SC_Value : MonoBehaviour
{
    private TextMeshProUGUI text;
    
    private int experience = 0;

    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    public void Increment()
    {
        experience = experience + 1;
        Debug.LogWarning(experience);
        text.text = experience.ToString();
        Debug.LogWarning(text.text);
    }
}
