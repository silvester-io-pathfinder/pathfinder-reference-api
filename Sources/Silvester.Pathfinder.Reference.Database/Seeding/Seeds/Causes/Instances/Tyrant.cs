using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Causes.Instances
{
    public class Tyrant : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Cause GetCause()
        {
            return new Cause
            {
                Id = ID, 
                Name = "Tyrant",
                DivineSmite = "The regrets of disobedience linger. If an enemy refuses your Iron Command, it takes persistent evil damage equal to your Charisma modifier.",
                Exalt = "When you use Iron Command, each enemy within 15 feet of you other than the triggering creature must also either drop prone or take mental damage (the enemy chooses). These creatures take only minimum damage (typically 3 damage at 11th level, 4 at 12th, 5 at 16th, and 6 at 19th), and the effects they take can't be adjusted by anything that changes your Iron Command. For instance, the Iron Repercussions feat couldn't turn the damage into persistent mental damage for creatures other than the triggering creature.",
                ClassId = Classes.Instances.Champion.ID,
                AlignmentId = Alignments.Instances.LawfulEvil.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Might makes right, and you subjugate the weak to keep them in their proper place. You gain the Iron Command champion's reaction and the touch of corruption devotion spell. After the tenets of evil, add these tenets." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Let no one who is lesser than you wield power over you or lead you." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Mercilessly enforce established hierarchies of masters and servants. Topple or seize control of illegitimate hierarchies, such as democratic governments or the arrogant echelons of the celestial planes, and fill power vacuums by taking that power for yourself." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Bind the weak to serve you. This tenet doesn't require you to spare foes' lives if you think they would be disloyal if pressed into servitude, nor does it require you to keep more servants than you find practical or useful." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse(""),
                FeatId = Feats.Instances.IronCommand.ID
            };

            yield return new GainSpecificSpellEffect
            {
                Id = Guid.Parse(""),
                SpellId = Spells.Instances.TouchOfCorruption.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 116
            };
        }
    }
}
