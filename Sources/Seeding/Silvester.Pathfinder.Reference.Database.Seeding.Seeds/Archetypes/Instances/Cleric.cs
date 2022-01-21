using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Cleric : Template
    {
        public static readonly Guid ID = Guid.Parse("21b8b529-7500-4272-859f-29166a65ca8c");
        
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
            yield return new TextBlock { Id = Guid.Parse("956a1f61-f4a1-4ffd-8ec9-fb36e1e9011a"), Type = TextBlockType.Text, Text = "You are an ordained priest of your deity and have even learned how to cast a few divine spells. Though your main training lies elsewhere, your religious calling provides you divine gifts." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c6aff760-3312-43ce-96fe-d36087175fa8"), Type = TextBlockType.Text, Text = "The cleric archetype is a great way to create a character of another class who�s a devotee of a particular deity. The many domains available to clerics of different deities present a variety of options for focus spells." };
            yield return new TextBlock { Id = Guid.Parse("47b69aba-8901-4fba-9dea-07516a3b6f68"), Type = TextBlockType.Enumeration, Text = "Alchemist clerics work well with the chirurgeon field, healing various ailments with either alchemy or spells." };
            yield return new TextBlock { Id = Guid.Parse("5d52ffbe-99df-49cf-96a9-da0bbaabbe01"), Type = TextBlockType.Enumeration, Text = "Martial clerics are typically looking for a potent domain spell or some healing to use in a pinch." };
            yield return new TextBlock { Id = Guid.Parse("20a629ad-0860-4e72-9f3e-91cc56506a8e"), Type = TextBlockType.Enumeration, Text = "Divine sorcerer clerics double down as the ultimate divine spellcasters." };
            yield return new TextBlock { Id = Guid.Parse("18889cc5-1aed-44ef-a270-e572de4d0793"), Type = TextBlockType.Enumeration, Text = "Other spellcaster clerics diversify their options, becoming theurgic characters who combine two magical traditions." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("015bb77f-9c14-4241-a579-8d8ad09d88b9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 224
            };
        }
    }
}
