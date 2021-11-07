using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnduringAlchemy : Template
    {
        public static readonly Guid ID = Guid.Parse("573f3ddb-7948-4e4b-be25-8a5fc87a3832");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Enduring Alchemy",
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
            yield return new TextBlock { Id = Guid.Parse("63ef5a4d-deeb-441c-bbe8-7836bd74701f"), Type = TextBlockType.Text, Text = "You’ve learned how to make your personal energy last just a little bit longer when quickly brewing ad hoc concoctions. When using (feat:lvl--1: Quick Alchemy) to create an alchemical tool or elixir, that tool or elixir remains potent until the end of your next turn, instead of losing its potency at the start of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a1defb27-ed62-45c1-ade3-e4e9da7454a0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
