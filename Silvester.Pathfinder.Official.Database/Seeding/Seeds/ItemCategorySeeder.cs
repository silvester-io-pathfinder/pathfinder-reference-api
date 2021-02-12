using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class ItemCategorySeeder : IEntitySeeder<ItemCategory>
    {
        public IEnumerable<ItemCategory> GetSeedEntities()
        {
            yield return new ItemCategory { Id = Guid.Parse("40c1e3c7-9870-4c2d-a45f-0f70f0d8139f"), PageNumber = 543, Name = "Alchemical Items", Description = "Powered by the reactions of alchemical reagents. Almost all alchemical items are consumable items that are used up when you activate them. This category includes bombs, elixirs (including mutagens), poisons, and alchemical tools." };
            yield return new ItemCategory { Id = Guid.Parse("a3d34e6e-4c6e-4351-8b66-3e9faf08ca8f"), PageNumber = 559, Name = "Ammunition", Description = "Includes different types of magical arrows, crossbow bolts, and other types of ammunition." };
            yield return new ItemCategory { Id = Guid.Parse("76b819ea-1c05-4a54-9b9a-3528535e8b68"), PageNumber = 603, Name = "Apex Items", Description = "A subcategory of worn items of a high level that increase an ability score." };
            yield return new ItemCategory { Id = Guid.Parse("5d8aa60d-58e9-425a-9c92-0cac9eb5202d"), PageNumber = 555, Name = "Armor", Description = "Includes the rules for basic magical armor as well as special suits of armor." };
            yield return new ItemCategory { Id = Guid.Parse("60022ff2-b13c-4a74-a82f-a084b5b9f44e"), PageNumber = 604, Name = "Companion Items", Description = "A category of worn items meant for animal companions and mounts." };
            yield return new ItemCategory { Id = Guid.Parse("14299b81-a8c5-4136-b230-ecbb7653a150"), PageNumber = 559, Name = "Consumables", Description = "Used up when you activate them, and include ammunition, oils, potions, scrolls, and talismans, among others. Categories of items that are consumables but have specific rules, such as alchemical items, are presented separately." };
            yield return new ItemCategory { Id = Guid.Parse("4346421f-aa3b-46aa-8783-3bdb5095df43"), PageNumber = 572, Name = "Held Items", Description = "A wide variety of items you use with your hands. This doesn’t include more narrow categories of held items, such as weapons." };
            yield return new ItemCategory { Id = Guid.Parse("9229852f-02cb-43d5-ae10-c1ab7bc66cfa"), PageNumber = 577, Name = "Materials", Description = "Can be used to make items with unique properties and other advantages." };
            yield return new ItemCategory { Id = Guid.Parse("cea8ef00-93a9-4657-a712-c4904a79a6c7"), PageNumber = 561, Name = "Oils", Description = "Consumables applied to the surface of an object or person." };
            yield return new ItemCategory { Id = Guid.Parse("f18f1a5c-790a-42ce-b629-1db465289c25"), PageNumber = 562, Name = "Potions", Description = "Consumable magical liquids you drink to activate." };
            yield return new ItemCategory { Id = Guid.Parse("8a494ffa-3f11-4e4e-9373-b376942fc75d"), PageNumber = 580, Name = "Runes", Description = "Modify armor and weapons when etched onto them. This section includes fundamental runes for weapons (weapon potency and striking) and armor (armor potency and resilient)." };
            yield return new ItemCategory { Id = Guid.Parse("44429e3b-ba5c-4733-826b-2a21758ebfca"), PageNumber = 564, Name = "Scrolls", Description = "Consumables that allow spellcasters to cast more spells." };
            yield return new ItemCategory { Id = Guid.Parse("eed4990e-e635-4683-a920-1937bf9736f2"), PageNumber = 586, Name = "Shields", Description = "More durable shields and ones with special magical powers." };
            yield return new ItemCategory { Id = Guid.Parse("4557c11d-e0fb-40ee-8b3c-b6c3340fc151"), PageNumber = 589, Name = "Snares", Description = "Single-use traps typically made by rangers." };
            yield return new ItemCategory { Id = Guid.Parse("64a4ddc3-6da3-475e-a65c-dafc742dfea7"), PageNumber = 592, Name = "Staves", Description = "Provide flexible spellcasting options." };
            yield return new ItemCategory { Id = Guid.Parse("680c5c0f-dc56-4937-a179-b78c90a94164"), PageNumber = 596, Name = "Structures", Description = "Buildings, tents, and other larger items." };
            yield return new ItemCategory { Id = Guid.Parse("559392e9-b613-46bd-87d8-e7f74a6c5d56"), PageNumber = 565, Name = "Talismans", Description = "Consumables that are affixed to items and then activated for a one-time combat or physical benefit." };
            yield return new ItemCategory { Id = Guid.Parse("8f737ba1-e70a-4583-b55c-cc874f0f5660"), PageNumber = 597, Name = "Wands", Description = "Hold a spell of the crafter’s choice, and can be used to repeatedly cast that spell." };
            yield return new ItemCategory { Id = Guid.Parse("7c5752cf-64d2-4d3e-a4ba-604969266172"), PageNumber = 599, Name = "Weapons", Description = "The rules for basic magical weapons, weapons made from precious materials, and specific magic weapons." };
            yield return new ItemCategory { Id = Guid.Parse("d907ade1-335e-48cd-9e9f-d407d11fd82b"), PageNumber = 603, Name = "Worn Items", Description = "Consist of a vast collection of clothing and other items you wear on your body." };
        }
    }
}
