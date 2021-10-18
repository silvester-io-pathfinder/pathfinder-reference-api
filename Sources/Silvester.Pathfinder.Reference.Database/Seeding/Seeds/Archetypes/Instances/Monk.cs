using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Monk : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Monk",
                IsMulticlassArchetype = true,
                DedicationFeatId = Feats.Instances.MonkDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Monastic training has taught you martial arts and allowed you to hone your mind, body, and spirit to new heights." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The monk archetype is a strong choice for any character that fights unarmored or with unarmed attacks." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Barbarian monks with the animal instinct can combine the barbarian’s excellent unarmed damage with the monk’s diverse unarmed special abilities." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Champion monks are perfect for champions of Irori or other deities who favor unarmed attacks." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Fighter monks can supplement free-hand fighting and add mobility to the fighter’s toolkit." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Rogue monks are incredibly effective because stances grant some of the best agile finesse attacks and flurry gives more sneak attacks." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Spellcaster monks can fight with a free hand and still use material components to cast spells." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 227
            };
        }
    }
}
