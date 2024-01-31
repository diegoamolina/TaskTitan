using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SC_AvatarSlot
{
    public Button button;
    public SC_Item item; 
    public SC_AvatarSlot(SC_Item item, VisualTreeAsset template)
    {
        TemplateContainer avatarButtonContainer = template.Instantiate();

        button = avatarButtonContainer.Q<Button>();
        this.item = item;

        button.RegisterCallback<ClickEvent>(OnClick);
    }

    public void OnClick(ClickEvent clickEvent)
    {
        Debug.LogWarning("The avatar slot with item " + item.displayName + " has been clicked");
    }
}
