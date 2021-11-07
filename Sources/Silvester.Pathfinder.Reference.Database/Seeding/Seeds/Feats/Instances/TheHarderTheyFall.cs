using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TheHarderTheyFall : Template
    {
        public static readonly Guid ID = Guid.Parse("39d279c0-2c0d-4060-9217-851f13cf9904");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "The Harder They Fall",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b3d8e1f9-2527-462e-97bf-189dc37044bb"), Type = TextBlockType.Text, Text = "You make your foes fall painfully when you trip them. When you successfully (action: Trip) a flat-footed foe, your target takes 1d6 bludgeoning damage. On a critical success, the target takes 1d6 bludgeoning damage plus your sneak attack damage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d3d36570-bd7c-46d6-8eed-6746e4123682"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
