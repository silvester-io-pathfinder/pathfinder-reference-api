using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Cleric : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Cleric",
                IsMulticlassArchetype = true,
                DedicationFeatId = Feats.Instances.ClericDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You are an ordained priest of your deity and have even learned how to cast a few divine spells. Though your main training lies elsewhere, your religious calling provides you divine gifts." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The cleric archetype is a great way to create a character of another class who’s a devotee of a particular deity. The many domains available to clerics of different deities present a variety of options for focus spells." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Alchemist clerics work well with the chirurgeon field, healing various ailments with either alchemy or spells." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Martial clerics are typically looking for a potent domain spell or some healing to use in a pinch." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Divine sorcerer clerics double down as the ultimate divine spellcasters." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Other spellcaster clerics diversify their options, becoming theurgic characters who combine two magical traditions." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 224
            };
        }
    }
}
