using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SongOfTheDeepCannotBreatheAir : Template
    {
        public static readonly Guid ID = Guid.Parse("876099c1-e4f3-4f05-9a98-f2e129f6cb5f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Song of the Deep - Cannot Breathe Air",
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
            yield return new TextBlock { Id = Guid.Parse("e8a0a31b-ccbd-47cb-be6c-317ef44225ed"), Type = TextBlockType.Text, Text = "You cannot breathe air, making you only able to breathe underwater. You gain a second ability boost, which is a free ability boost." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8f2a427a-b672-4694-abac-5a08bb599b2d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
