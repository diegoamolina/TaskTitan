using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SC_Avatar : MonoBehaviour
{
    UIDocument UI_Avatar;
    public VisualTreeAsset AvatarTemplate;
    public List<SC_Item> Items;

    private void OnEnable()
    {
        UI_Avatar = GetComponent<UIDocument>();

        

        foreach(SC_Item item in Items)
        {
            SC_AvatarSlot newAvatarSlot = new SC_AvatarSlot(item, AvatarTemplate);

            UI_Avatar.rootVisualElement.Q("AvatarRow").Add(newAvatarSlot.button);

            
        }
        
    }
}
