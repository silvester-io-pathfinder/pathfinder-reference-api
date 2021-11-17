using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReptileRider : Template
    {
        public static readonly Guid ID = Guid.Parse("ba449920-c002-4676-a996-78657e6e401e");

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
            yield return new TextBlock { Id = Guid.Parse("7fccdfcc-4f8b-4772-b8b1-4cbccf0ede14"), Type = TextBlockType.Text, Text = "To you, crocodilians, giant lizards, and dinosaurs are loyal steeds, not monsters. You gain the (feat: Ride) feat, even if you don’t meet the prerequisites. You gain a +1 circumstance bonus to Nature checks to (action: Command an Animal) as long as the animal is a reptile, dinosaur, or even a non-sapient dragon." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b023ca9a-0d99-4dba-8af8-73e66ca5d855"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
