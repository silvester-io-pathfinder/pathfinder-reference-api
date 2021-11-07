using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DruidElementalistKeepTempestSurge : Template
    {
        public static readonly Guid ID = Guid.Parse("303cbead-b760-47bb-808c-686119934467");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Druid Elementalist - Keep Tempest Surge",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("26d42443-cfcc-4910-868b-f088f3026fa3"), Type = TextBlockType.Text, Text = "You choose not to replace your starting order spell, (spell: tempest surge), with (spell: updraft)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a944c30f-a542-4806-91b2-4454b97a2cdc"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
