using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Causes.Instances
{
    public class Tyrant : Template
    {
        public static readonly Guid ID = Guid.Parse("a6269607-7922-4ee3-833c-ffda3f21b563");
        
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
            yield return new TextBlock { Id = Guid.Parse("793379d0-7366-4be9-a338-30fb98a538c3"), Type = TextBlockType.Text, Text = "Might makes right, and you subjugate the weak to keep them in their proper place. You gain the Iron Command champion's reaction and the touch of corruption devotion spell. After the tenets of evil, add these tenets." };
            yield return new TextBlock { Id = Guid.Parse("641e8235-e5d9-4b96-b0ad-d6d67de8b3a2"), Type = TextBlockType.Enumeration, Text = "Let no one who is lesser than you wield power over you or lead you." };
            yield return new TextBlock { Id = Guid.Parse("dfe1289f-37bf-4c9d-a5ce-3a00c6cd66a0"), Type = TextBlockType.Enumeration, Text = "Mercilessly enforce established hierarchies of masters and servants. Topple or seize control of illegitimate hierarchies, such as democratic governments or the arrogant echelons of the celestial planes, and fill power vacuums by taking that power for yourself." };
            yield return new TextBlock { Id = Guid.Parse("ac3e9d75-3ed9-4652-8894-da2357b86d65"), Type = TextBlockType.Enumeration, Text = "Bind the weak to serve you. This tenet doesn't require you to spare foes' lives if you think they would be disloyal if pressed into servitude, nor does it require you to keep more servants than you find practical or useful." };
        }


        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("38f7432f-9df9-46cc-81fa-1ffa367e9635"), Feats.Instances.IronCommand.ID);
            builder.GainSpecificSpell(Guid.Parse("f638ba01-79ee-4144-8fcf-99f03ba32064"), Spells.Instances.TouchOfCorruption.ID);
         
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("202e0503-317f-4865-af66-fc3603fc52d4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 116
            };
        }
    }
}
