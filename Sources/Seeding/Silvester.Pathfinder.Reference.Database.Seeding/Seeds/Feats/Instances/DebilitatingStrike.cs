using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DebilitatingStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("211f3fc9-833c-4de3-b96b-a1db1af03adb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Debilitating Strike",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your Strike hits a flat-footed creature and deals damage.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("66a66727-7c44-4692-a595-2b01561d6636"), Type = TextBlockType.Text, Text = "You apply one of the following debilitations, which lasts until the end of your next turn." };
            yield return new TextBlock { Id = Guid.Parse("3f0da6ec-88d9-498f-a680-9de0d21a6bba"), Type = TextBlockType.Text, Text = "~ Debilitation: The target takes a -10-foot status penalty to its Speeds." };
            yield return new TextBlock { Id = Guid.Parse("99b63cd7-d797-43ac-9d68-39d1e224801b"), Type = TextBlockType.Text, Text = "~ Debilitation: The target becomes enfeebled 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("826e930f-f87c-4200-a39a-9d5bb3aa7e3a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
