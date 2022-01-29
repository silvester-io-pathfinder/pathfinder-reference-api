using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Alchemist : Template
    {
        public static readonly Guid ID = Guid.Parse("9f16d9a5-cb0e-4957-ab34-9780059d02a3");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Alchemist",
                IsMulticlassArchetype = true,
                DedicationFeatId = Feats.Instances.AlchemistDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("94a60ff4-b3a3-475c-9f9e-10acea068740"), Type = TextBlockType.Text, Text = "You enjoy tinkering with alchemical formulas and substances in your spare time, and your studies have progressed beyond mere experimentation." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("532f8203-4f04-4e6c-b71a-b2d095f802d6"), Type = TextBlockType.Text, Text = "The free alchemical items from the alchemist archetype are extremely useful to characters of any class. The following are just some of the possible combinations." };
            yield return new TextBlock { Id = Guid.Parse("445a9bd4-db71-4619-bd5d-65b57654b96b"), Type = TextBlockType.Enumeration, Text = "Barbarian alchemists can mix mutagens with their rage to ferocious effect." };
            yield return new TextBlock { Id = Guid.Parse("901b8722-ca5d-4e50-af2c-986eb8ad9b17"), Type = TextBlockType.Enumeration, Text = "Champion alchemists can focus on alchemical items that boost defenses and heal others, allowing their champion's reaction and lay on hands to go further." };
            yield return new TextBlock { Id = Guid.Parse("9343da45-2701-4b3f-b6ab-8e2a21334311"), Type = TextBlockType.Enumeration, Text = "Fighter alchemists can use their alchemy to gain additional options in situations where their usual tactics don't work." };
            yield return new TextBlock { Id = Guid.Parse("54154704-b72e-45f3-95f1-d9b4450ee40f"), Type = TextBlockType.Enumeration, Text = "Ranger alchemists focus on alchemy and snares, getting extra use out of their Crafting skill and supplying bombs for the bomb snare." };
            yield return new TextBlock { Id = Guid.Parse("365dcd35-0b75-4e61-b8c0-5c7d539440f7"), Type = TextBlockType.Enumeration, Text = "Rogue alchemists can combine a rogue's poison feats with free daily poisons, and bombs present an interesting way to sneak attack with various types of energy damage." };
            yield return new TextBlock { Id = Guid.Parse("fedff49c-a6c6-47da-8aef-c3f125d34269"), Type = TextBlockType.Enumeration, Text = "Spellcaster alchemists often use their alchemical items to take pressure off their repertoire or prepared spells. For instance, a wizard alchemist who can brew up darksight elixirs to grant darkvision can prepare another spell instead of darkvision." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bf2bb4b0-6121-4908-8d12-c6721da7a1dd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 220
            };
        }
    }
}
