using ArmoryClient.Models;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmoryClient.UI.ViewModel;

public class ItemViewModel : ViewModelBase
{
    private readonly Item _item;

    public ItemViewModel(Item item)
    {
        _item= item;
    }

    public string Name => _item.Name;
    public string Difficulty => _item.Difficulty;
    public string ItemLevel => _item.ItemLevel;
    public string ItemBinding => _item.Binding;
    public string Slot => _item.Slot.ToString();
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
