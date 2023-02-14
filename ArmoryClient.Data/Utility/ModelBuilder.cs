using System.Collections.Generic;
using System.Linq;
using ArmoryClient.Data.DTO;
using ArmoryClient.Models;

namespace ArmoryClient.Data.Utility;

public static class ModelBuilder
{
    public static Item ItemFromDTO(ItemDTO dto)
    {
        return new Item
        {
            Name = dto.Name,
            NameDescription = dto.NameDescription != null
                ? dto.NameDescription.DisplayString
                : string.Empty,
            ArmorText = dto.Armor != null
                ? dto.Armor.DisplayInformation.DisplayString
                : string.Empty,
            Binding = dto.Binding.Name,
            ClassText = dto.Requirements != null && dto.Requirements.Class != null
                ? dto.Requirements.Class.DisplayString
                : string.Empty,
            ItemLevel = dto.Level.DisplayString,
            ItemType = dto.ItemClass.Name,
            LevelText = dto.Requirements != null && dto.Requirements.Level != null
                ? dto.Requirements.Level.DisplayString
                : string.Empty,
            EquippedSlot = dto.Slot.Name,
            Slot = dto.InventoryType.Name,
            StaminaText = dto.Stats.First(s => s.StatType.Name == "Stamina").DisplayInformation.DisplayString,
            PrimaryStats = dto.Stats
                .Where(s =>
                    s.StatType.Name == "Strength" ||
                    s.StatType.Name == "Agility" ||
                    s.StatType.Name == "Intelligence")
                .Select(s => s.DisplayInformation.DisplayString)
                .ToList(),
            SecondaryStats = dto.Stats
                .Where(s =>
                    s.StatType.Name != "Strength" &&
                    s.StatType.Name != "Agility" &&
                    s.StatType.Name != "Intelligence" &&
                    s.StatType.Name != "Stamina")
                .Select(s => s.DisplayInformation.DisplayString)
                .ToList()
        };
    }

    public static CharacterEquipment EquipmentFromItems(IEnumerable<Item> items)
    {
        var equip = new CharacterEquipment
        {
            Back = items.First(i => i.EquippedSlot == "Back"),
            Chest = items.First(i => i.EquippedSlot == "Chest"),
            Feet = items.First(i => i.EquippedSlot == "Feet"),
            Hands = items.First(i => i.EquippedSlot == "Hands"),
            Head = items.First(i => i.EquippedSlot == "Head"),
            Legs = items.First(i => i.EquippedSlot == "Legs"),
            Mainhand = items.First(i => i.EquippedSlot == "Main Hand"),
            Neck = items.First(i => i.EquippedSlot == "Neck"),
            Offhand = items.First(i => i.EquippedSlot == "Off Hand"),
            Ring1 = items.First(i => i.EquippedSlot == "Ring 1"),
            Ring2 = items.First(i => i.EquippedSlot == "Ring 2"),
            Shirt = items.First(i => i.EquippedSlot == "Shirt"),
            Shoulders = items.First(i => i.EquippedSlot == "Shoulders"),
            Tabard = items.First(i => i.EquippedSlot == "Tabard"),
            Trinket1 = items.First(i => i.EquippedSlot == "Trinket 1"),
            Trinket2 = items.First(i => i.EquippedSlot == "Trinket 2"),
            Waist = items.First(i => i.EquippedSlot == "Waist"),
            Wrist = items.First(i => i.EquippedSlot == "Wrist")
        };

        return equip;
    }

    public static IEnumerable<Item> ItemsFromDTOs(CharacterEquipmentAPIResponseDTO dto)
    {
        foreach (var item in dto.Equipment)
        {
            yield return ItemFromDTO(item);
        }
    }
}