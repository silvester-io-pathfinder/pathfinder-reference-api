using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ChannelSmite : Template
    {
        public static readonly Guid ID = Guid.Parse("d471684b-2e04-4d76-9a59-ae96d3589d41");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Channel Smite",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a56fd7bf-e10e-4a88-9490-ded3347cdf30"), Type = TextBlockType.Text, Text = "You siphon the destructive energies of positive or negative energy through a melee attack and into your foe. Make a melee (action: Strike) and add the spell’s damage to the Strike’s damage. This is negative damage if you expended a (spell: harm) spell or positive damage if you expended a (spell: heal) spell." };
            yield return new TextBlock { Id = Guid.Parse("8f0de575-8e9c-40b5-be05-b13f3d26d4f2"), Type = TextBlockType.Text, Text = "The spell is expended with no effect if your (action: Strike) fails or hits a creature that isn’t damaged by that energy type (such as if you hit a non-undead creature with a heal spell)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("22d187e9-bcc3-438e-a476-e0bdcdaa6750"), or => 
            {
                or.HaveSpecificDivineFont(Guid.Parse("e60bc993-2f46-42b2-ac77-97d86ace126e"), DivineFonts.Instances.Heal.ID);
                or.HaveSpecificDivineFont(Guid.Parse("2796cf41-183c-48c2-af25-4679002ba273"), DivineFonts.Instances.Harm.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7a6acfc3-eae0-4d51-93fe-1c0fed4e0bea"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
