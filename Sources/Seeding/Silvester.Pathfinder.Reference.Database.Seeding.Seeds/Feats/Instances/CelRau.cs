using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CelRau : Template
    {
        public static readonly Guid ID = Guid.Parse("43d383b4-63eb-4cb4-b563-1662613330af");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cel Rau",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2882f158-57bf-447d-9e91-d1e7f8e0e2c6"), Type = TextBlockType.Text, Text = $"You are a cel rau, child of a strigoi, one of the first vampires to walk Golarion. Your heritage ties you to the Shadow Plane and grants you strange resilience to light and darkness alike. You gain a +1 circumstance bonus to saving throws against effects with the {ToMarkdownLink<Models.Entities.Trait>("darkness", Traits.Instances.Darkness.ID)}, {ToMarkdownLink<Models.Entities.Trait>("light", Traits.Instances.Light.ID)}, or {ToMarkdownLink<Models.Entities.Trait>("shadow", Traits.Instances.Shadow.ID)} traits, and whenever you become dazzled or blinded for at least 2 rounds, you can reduce the duration by 1 round." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3b798d9d-67b0-458f-9615-780bfd0083e9"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
