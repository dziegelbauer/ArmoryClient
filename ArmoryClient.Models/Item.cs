// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

using System.Collections.Generic;

namespace ArmoryClient.Models;

public class Item
{
    public string Name { get; set; }
    public string NameDescription { get; set; }
    public string ItemLevel { get; set; }
    public string Binding { get; set; }
    public string EquippedSlot { get; set; }
    public string Slot { get; set; }
    public string ItemType { get; set; }
    public string ArmorText { get; set; }
    public string StaminaText { get; set; }
    public string ClassText { get; set; }
    public string LevelText { get; set; }
    public List<string> PrimaryStats { get; set; }
    public List<string> SecondaryStats { get; set; }
}