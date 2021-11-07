using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MasterSummoner : Template
    {
        public static readonly Guid ID = Guid.Parse("860db669-7d00-47b1-9dce-9747dd555c92");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Master Summoner",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("01df797b-7450-4602-8a0c-0c792963dc33"), Type = TextBlockType.Text, Text = "During daily preparations, you can designate one of your spell slots to become two summoning slots of the same spell level, from which you can cast only summoning or (trait: incarnate) spells." };
            yield return new TextBlock { Id = Guid.Parse("ab75ea0b-ba33-408e-8c01-ed8ec37067a4"), Type = TextBlockType.Text, Text = "__You can manually add and change the color of spell slots under Manage Spells on the sheet.__" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c78534bc-62df-47a6-8f54-0a86381a67c3"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
