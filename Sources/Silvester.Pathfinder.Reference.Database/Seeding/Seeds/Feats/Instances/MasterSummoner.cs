using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MasterSummoner : Template
    {
        public static readonly Guid ID = Guid.Parse("2cb09022-8a7a-4aa1-9c2e-0669e6b88063");

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
            yield return new TextBlock { Id = Guid.Parse("16cd3527-203d-49ff-b8f9-8987ff92a2a1"), Type = TextBlockType.Text, Text = "During daily preparations, you can designate one of your spell slots to become two summoning slots of the same spell level, from which you can cast only summoning or (trait: incarnate) spells." };
            yield return new TextBlock { Id = Guid.Parse("5341ac3c-03a3-404b-a83f-7165bde5563e"), Type = TextBlockType.Text, Text = "__You can manually add and change the color of spell slots under Manage Spells on the sheet.__" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("602d0d89-e2d6-482a-9fc8-66e11fde45e7"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
