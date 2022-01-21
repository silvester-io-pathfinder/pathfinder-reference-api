using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CloakOfPoison : Template
    {
        public static readonly Guid ID = Guid.Parse("c47b351c-f0ca-4852-9e1c-6c6218843187");

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
            yield return new TextBlock { Id = Guid.Parse("8c0a4010-ca4b-4409-99dd-58c25d78e54d"), Type = TextBlockType.Text, Text = $"You secrete a cloak of concentrated poison that harms any who dare attack you. For 1 minute, any creature that touches you or damages you with an unarmed attack or melee weapon without the {ToMarkdownLink<Models.Entities.Trait>("reach", Traits.Instances.Reach.ID)} trait takes 3d6 poison damage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ed8bba17-d8ce-472d-8703-e3e29fdb6130"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
