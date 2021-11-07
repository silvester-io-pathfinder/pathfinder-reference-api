using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CloakOfPoison : Template
    {
        public static readonly Guid ID = Guid.Parse("b9182bbf-9d3a-42bb-84c8-3cb526e40e3f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cloak of Poison",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1a69ae6b-0419-4802-bfae-6e08ac4d2f30"), Type = TextBlockType.Text, Text = "You secrete a cloak of concentrated poison that harms any who dare attack you. For 1 minute, any creature that touches you or damages you with an unarmed attack or melee weapon without the (trait: reach) trait takes 3d6 poison damage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0c823d92-4446-4dff-a46e-f39805d74216"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
