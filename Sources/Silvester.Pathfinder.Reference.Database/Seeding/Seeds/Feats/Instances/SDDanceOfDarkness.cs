using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SDDanceOfDarkness : Template
    {
        public static readonly Guid ID = Guid.Parse("f5480c99-b391-4f5e-bce7-0fe5cc2e19c8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "SD - Dance of Darkness",
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
            yield return new TextBlock { Id = Guid.Parse("20043952-f28b-4de2-aaf5-d216616b227d"), Type = TextBlockType.Text, Text = "You learn the (spell: dance of darkness) shadowdancer focus spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("34d1aa50-d34b-438e-9f4d-6130ab201421"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
