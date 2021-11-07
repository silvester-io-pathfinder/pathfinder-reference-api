using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WishForLuck : Template
    {
        public static readonly Guid ID = Guid.Parse("001b8d56-9354-44ed-825a-9ddf5e91b963");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wish for Luck",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are about to roll an attack roll, saving throw, or skill check.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("82223142-4721-4993-aa1d-bcf9daaa9c84"), Type = TextBlockType.Text, Text = "You wish aloud for success. Roll the check twice and take the higher result." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("68961530-750c-46ee-9441-5031d486eacf"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
