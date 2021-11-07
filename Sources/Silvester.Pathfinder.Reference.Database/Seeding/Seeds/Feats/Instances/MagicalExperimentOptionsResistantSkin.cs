using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagicalExperimentOptionsResistantSkin : Template
    {
        public static readonly Guid ID = Guid.Parse("614cc487-fe5e-40a8-b241-853b8a02a806");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magical Experiment Options - Resistant Skin",
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
            yield return new TextBlock { Id = Guid.Parse("19aef3f5-97a8-49c6-ad82-2f6a0555509a"), Type = TextBlockType.Text, Text = "The experiments rendered your skin tougher and resilient to a particular type of damage. You gain resistance equal to half your level (minimum resistance 1) against two of the following types of energy damage, one chosen by you and the other chosen by the GM: acid, cold, electricity, fire, or sonic." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("06935df7-35ae-4acd-a65e-160a04054096"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
