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
            StaminaText = dto.Stats != null && dto.Stats.Any(s => s.StatType.Name == "Stamina")
                ? dto.Stats
                    .First(s => s.StatType.Name == "Stamina")
                    .DisplayInformation
                    .DisplayString
                : string.Empty,
            PrimaryStats = dto.Stats != null
                ? dto.Stats.Where(s =>
                        s.StatType.Name == "Strength" ||
                        s.StatType.Name == "Agility" ||
                        s.StatType.Name == "Intelligence")
                    .Select(s => s.DisplayInformation.DisplayString)
                    .ToList()
                : new List<string>(),
            SecondaryStats = dto.Stats != null
                ? dto.Stats.Where(s =>
                        s.StatType.Name != "Strength" &&
                        s.StatType.Name != "Agility" &&
                        s.StatType.Name != "Intelligence" &&
                        s.StatType.Name != "Stamina")
                    .Select(s => s.DisplayInformation.DisplayString)
                    .ToList()
                : new List<string>()
        };
    }

    public static CharacterEquipment EquipmentFromItems(IEnumerable<Item> items)
    {
        var equip = new CharacterEquipment
        {
            Back = items.FirstOrDefault(i => i.EquippedSlot == "Back"),
            Chest = items.FirstOrDefault(i => i.EquippedSlot == "Chest"),
            Feet = items.FirstOrDefault(i => i.EquippedSlot == "Feet"),
            Hands = items.FirstOrDefault(i => i.EquippedSlot == "Hands"),
            Head = items.FirstOrDefault(i => i.EquippedSlot == "Head"),
            Legs = items.FirstOrDefault(i => i.EquippedSlot == "Legs"),
            Mainhand = items.FirstOrDefault(i => i.EquippedSlot == "Main Hand"),
            Neck = items.FirstOrDefault(i => i.EquippedSlot == "Neck"),
            Offhand = items.FirstOrDefault(i => i.EquippedSlot == "Off Hand"),
            Ring1 = items.FirstOrDefault(i => i.EquippedSlot == "Ring 1"),
            Ring2 = items.FirstOrDefault(i => i.EquippedSlot == "Ring 2"),
            Shirt = items.FirstOrDefault(i => i.EquippedSlot == "Shirt"),
            Shoulders = items.FirstOrDefault(i => i.EquippedSlot == "Shoulders"),
            Tabard = items.FirstOrDefault(i => i.EquippedSlot == "Tabard"),
            Trinket1 = items.FirstOrDefault(i => i.EquippedSlot == "Trinket 1"),
            Trinket2 = items.FirstOrDefault(i => i.EquippedSlot == "Trinket 2"),
            Waist = items.FirstOrDefault(i => i.EquippedSlot == "Waist"),
            Wrist = items.FirstOrDefault(i => i.EquippedSlot == "Wrist")
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