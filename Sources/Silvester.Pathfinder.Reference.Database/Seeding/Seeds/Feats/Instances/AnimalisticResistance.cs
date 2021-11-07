using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnimalisticResistance : Template
    {
        public static readonly Guid ID = Guid.Parse("e264113b-fec8-4c93-831a-b6c96f213c6e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Animalistic Resistance",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("43883c3c-5581-47e0-9723-07a2c3453c07"), Type = TextBlockType.Text, Text = "Your animalistic connections help you resist natural afflictions. You gain a +2 circumstance bonus to saves to resist diseases and poisons." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6600e63f-c1e1-4e5f-b504-74c02964e492"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
