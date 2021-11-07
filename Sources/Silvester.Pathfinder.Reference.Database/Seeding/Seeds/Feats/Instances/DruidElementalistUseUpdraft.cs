using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DruidElementalistUseUpdraft : Template
    {
        public static readonly Guid ID = Guid.Parse("14fcc0ed-0c44-44fa-b8f6-9e94287c981d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Druid Elementalist - Use Updraft",
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
            yield return new TextBlock { Id = Guid.Parse("b5767d5c-78b9-432a-a275-f2b780138fb0"), Type = TextBlockType.Text, Text = "You replace your starting order spell, (spell: tempest surge), with (spell: updraft)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8ecb3647-2740-40f5-9ba5-027ad07d4a27"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
