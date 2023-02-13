// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ArmoryClient.Models;

public class Item
{
    public string Name { get; set; }
    public string Difficulty { get; set; }
    public string ItemLevel { get; set; }
    public string Binding { get; set; }
    public ArmorSlot Slot { get; set; }

    public string ItemType { get; set; }
    public string ArmorText { get; set; }
    public string StaminaText { get; set; }
    public string ClassText { get; set; }
    public string LevelText { get; set; }
}
