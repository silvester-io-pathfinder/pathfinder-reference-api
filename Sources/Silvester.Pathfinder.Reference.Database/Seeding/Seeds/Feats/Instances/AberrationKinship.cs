using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AberrationKinship : Template
    {
        public static readonly Guid ID = Guid.Parse("2efdd006-8136-4600-a255-84aa9eb5a9ce");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aberration Kinship",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fb2ef42c-fbbf-4e78-8aff-9ae93640019d"), Type = TextBlockType.Text, Text = "Your mind resonates with the inscrutable thought processes that inhuman aberrations use to communicate. You can cast (spell: mindlink) as an innate occult spell once per day, but you can target only aberrations." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b8807917-165d-4673-aa0f-64f9d2b32bdf"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
