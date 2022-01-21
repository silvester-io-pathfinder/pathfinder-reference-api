using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PickUpThePace : Template
    {
        public static readonly Guid ID = Guid.Parse("a1f4e90c-25d8-4482-baec-1c27fc972c2a");

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
            yield return new TextBlock { Id = Guid.Parse("8d785247-0c4f-4743-bb2c-be632bd3feaf"), Type = TextBlockType.Text, Text = "You lead by example and can help others push themselves beyond their normal limits. When (action: Hustling | Hustle) in a group during exploration mode, your group can (action: Hustle) for up to 20 additional minutes, to a maximum of the amount of time the character with the highest Constitution modifier could (action: Hustle) alone." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("be353029-6477-4632-9854-99139415632e"), requiredStatValue: 14, Stats.Instances.Constitution.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de6d77ef-591d-43be-8481-1bc1cacd7a7c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}