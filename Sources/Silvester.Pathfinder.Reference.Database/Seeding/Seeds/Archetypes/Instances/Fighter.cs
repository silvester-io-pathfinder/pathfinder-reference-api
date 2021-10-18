using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Fighter : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Fighter",
                IsMulticlassArchetype = true,
                DedicationFeatId = Feats.Instances.FighterDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You have spent time learning the art of warfare, increasing your skill with martial arms and at wearing armor. With further training, you can become a true combat specialist." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The fighter archetype grants access to great feats for characters focusing on any combat style, and it’s particularly helpful for characters looking to diversify their offensive abilities or focus on more powerful weapons." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Barbarian fighters can combine their talents with two - handed weapons with some of the fighter’s two - handed feats to devastating effect." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Champion fighters focus on a style of combat exemplified by their deity.A shield -using champion benefits from the best of both worlds in shield feats." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Monk fighters are great at combining unusual weapon styles. For instance, a monks isn’t hindered by a restriction to keep one hand free, because they want to punch you with that hand anyway." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Ranger fighters can either specialize in archery or use their fighter feats to pick up an unusual combat style combination." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Rogue fighters can make good use of fighter’s free hand, two-weapon fighting, or archery feats." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Spellcaster fighters benefit greatly from the additional weapon proficiencies, and fighter is a solid choice for any spellcaster of a particularly martial bent." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 226
            };
        }
    }
}
