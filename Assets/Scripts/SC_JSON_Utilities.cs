using UnityEngine;
using System.IO;
using TMPro;


public class SC_JSON_Utilities : MonoBehaviour
{
    private int experience;
    private string nameThisObject;

    private TextMeshProUGUI text;

    private void Start()
    {
        nameThisObject = name;
        Debug.LogWarning(nameThisObject);
        text = GetComponent<TextMeshProUGUI>();
        LoadFromJson();
        Debug.LogWarning(text.text);
    }

    public void Increment()
    {
        experience++;
        text.text = experience.ToString();
        SaveToJson();
    }

    public void SaveToJson()
    {
        UserData data = new UserData();
        data.experience = experience;
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.dataPath + "/"+ nameThisObject +".json", json);
    }

    public void LoadFromJson()
    {
        string json = File.ReadAllText(Application.dataPath + "/" + nameThisObject + ".json");
        UserData data = JsonUtility.FromJson<UserData>(json);
        experience = data.experience;
        text.text = experience.ToString();
    }
}
