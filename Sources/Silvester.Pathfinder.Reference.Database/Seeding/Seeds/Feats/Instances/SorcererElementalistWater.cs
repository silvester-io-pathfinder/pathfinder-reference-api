using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SorcererElementalistWater : Template
    {
        public static readonly Guid ID = Guid.Parse("9db055ae-b9c6-4ed4-8025-cd11e8621808");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sorcerer Elementalist - Water",
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
            yield return new TextBlock { Id = Guid.Parse("fdbcaf4c-e2c7-4c8d-9f7d-86d046ed3379"), Type = TextBlockType.Text, Text = "You replace your initial bloodline spell with the initial water elemental focus spell ((spell: rising surf)), and your advanced bloodline spell (if you get it) with the advanced water elemental focus spell ((spell: pulverizing cascade))." };
            yield return new TextBlock { Id = Guid.Parse("79065fc1-841b-45a0-a1aa-1ff449dbab89"), Type = TextBlockType.Text, Text = "You can only select this option if your bloodline&#39;s elemental type is water." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ca4ca6c2-fa53-4f44-bf40-e3c863b38187"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
