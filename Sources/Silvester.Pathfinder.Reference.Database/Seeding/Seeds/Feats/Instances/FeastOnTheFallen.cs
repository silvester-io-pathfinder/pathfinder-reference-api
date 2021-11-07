using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FeastOnTheFallen : Template
    {
        public static readonly Guid ID = Guid.Parse("50c53898-97f5-4bb3-8999-ffc7e702340f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Feast on the Fallen",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature adjacent to the vulture is reduced to 0 Hit Points.",
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b0bf6c7e-aa5a-40b0-8062-6b45483bf36d"), Type = TextBlockType.Text, Text = "The vulture consumes a piece of the defeated foe, regaining 18 Hit Points. If the vulture is a specialized animal companion, increase the Hit Points regained to 30." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ed5b383-1834-4ba0-80b2-23125ddb5524"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
