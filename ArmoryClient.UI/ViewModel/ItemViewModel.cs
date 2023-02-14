using System;
using ArmoryClient.Models;

namespace ArmoryClient.UI.ViewModel;

public class ItemViewModel : ViewModelBase
{
    private readonly Item _item;

    public ItemViewModel(Item item)
    {
        _item = item;
    }

    public string Name => _item.Name;
    public string NameDescription => _item.NameDescription;
    public string ItemLevel => _item.ItemLevel;
    public string ItemBinding => _item.Binding;
    public string Slot => _item.EquippedSlot;
    public string ArmorType => _item.ItemType;
    public string ArmorText => _item.ArmorText;
    public string MainStatText => BuildMainStatText();
    public string StaminaText => _item.StaminaText;
    public string SecondaryStatText => BuildSecondaryStatText();
    public string ClassText => _item.ClassText;
    public string LevelText => _item.LevelText;

    private string BuildMainStatText()
    {
        throw new NotImplementedException();
    }

    private string BuildSecondaryStatText()
    {
        throw new NotImplementedException();
    }
}