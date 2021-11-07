using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PickUpThePace : Template
    {
        public static readonly Guid ID = Guid.Parse("16ba6097-dc1e-4db4-b4c1-593f7a620230");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pick up the Pace",
                Level = 3,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7dae6687-cd64-46a8-97cc-66648d9e2cde"), Type = TextBlockType.Text, Text = "You lead by example and can help others push themselves beyond their normal limits. When (action: Hustling | Hustle) in a group during exploration mode, your group can (action: Hustle) for up to 20 additional minutes, to a maximum of the amount of time the character with the highest Constitution modifier could (action: Hustle) alone." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("a155aa13-ae55-4b3d-93da-9a7da884477a"), requiredStatValue: 14, Stats.Instances.Constitution.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ed6738a5-3776-4b35-a085-bdadace0b51e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
