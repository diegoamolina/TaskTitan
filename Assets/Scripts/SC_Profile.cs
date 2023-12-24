using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SC_Profile : MonoBehaviour
{
    private GameObject valueObject;
    private TextMeshPro valueText;

    private int value = 0;

    private void Start()
    {
        valueObject = GetChildWithName(this.gameObject, "Value");
        valueText = valueObject.GetComponent<TextMeshPro>();
    }

    GameObject GetChildWithName(GameObject obj, string name)
    {
        Transform trans = obj.transform;
        Transform childTrans = trans.Find(name);
        if (childTrans != null)
        {
            return childTrans.gameObject;
        }
        else
        {
            return null;
        }
    }

    public void Increment()
    {
        value = value + 1;
        Debug.LogWarning(value);
        valueText.text = value.ToString();
        Debug.LogWarning(valueText.text);

    }

    public void GoToScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    IEnumerator WaitFor(float time)
    {
        yield return new WaitForSeconds(time);
    }
}
