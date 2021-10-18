using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Alchemist : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You enjoy tinkering with alchemical formulas and substances in your spare time, and your studies have progressed beyond mere experimentation." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The free alchemical items from the alchemist archetype are extremely useful to characters of any class. The following are just some of the possible combinations." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Barbarian alchemists can mix mutagens with their rage to ferocious effect." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Champion alchemists can focus on alchemical items that boost defenses and heal others, allowing their champion’s reaction and lay on hands to go further." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Fighter alchemists can use their alchemy to gain additional options in situations where their usual tactics don’t work." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Ranger alchemists focus on alchemy and snares, getting extra use out of their Crafting skill and supplying bombs for the bomb snare." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Rogue alchemists can combine a rogue’s poison feats with free daily poisons, and bombs present an interesting way to sneak attack with various types of energy damage." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Spellcaster alchemists often use their alchemical items to take pressure off their repertoire or prepared spells. For instance, a wizard alchemist who can brew up darksight elixirs to grant darkvision can prepare another spell instead of darkvision." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 220
            };
        }
    }
}
