using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnburdenedIron : Template
    {
        public static readonly Guid ID = Guid.Parse("e75d2930-ddc5-49f7-abad-2e1de376b437");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unburdened Iron",
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
            yield return new TextBlock { Id = Guid.Parse("f23e3d68-5b8b-4caf-b46b-201eef595735"), Type = TextBlockType.Text, Text = "You’ve learned techniques first devised by your ancestors during their ancient wars, allowing you to comfortably wear massive suits of armor. Ignore the reduction to your Speed from any armor you wear." };
            yield return new TextBlock { Id = Guid.Parse("73bbcf0d-5642-4c92-bb9a-3d61e11566f7"), Type = TextBlockType.Text, Text = "In addition, any time you’re taking a penalty to your Speed from some other reason, deduct 5 feet from the penalty. If your Speed is taking multiple penalties, pick only one penalty to reduce." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("613d4e31-3a5d-4816-b7ba-7ff55fbbe737"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
