using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReptileRider : Template
    {
        public static readonly Guid ID = Guid.Parse("cd653357-a8ce-4758-bb81-8f75a9e19a30");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reptile Rider",
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
            yield return new TextBlock { Id = Guid.Parse("fbe702ce-7fa2-4929-8fb0-c113f84cbe43"), Type = TextBlockType.Text, Text = "To you, crocodilians, giant lizards, and dinosaurs are loyal steeds, not monsters. You gain the (feat: Ride) feat, even if you don’t meet the prerequisites. You gain a +1 circumstance bonus to Nature checks to (action: Command an Animal) as long as the animal is a reptile, dinosaur, or even a non-sapient dragon." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("43d8a2b6-796d-49cf-a6bd-46a047afaefb"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
