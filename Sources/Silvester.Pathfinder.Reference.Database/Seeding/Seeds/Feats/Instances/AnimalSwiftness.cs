using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AnimalSwiftness : Template
    {
        public static readonly Guid ID = Guid.Parse("d5c01ca2-4fd8-4ff7-b608-311b2c95292e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Animal Swiftness",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3c323fc1-c2a4-4447-be26-cf5b35ca1a02"), Type = TextBlockType.Text, Text = "You move like an animal. Your Speed increases by 5 feet. In addition, you gain one of the following Speeds available to your inherent animal: climb, fly, or swim. You gain this Speed only while in your hybrid shape." };
            yield return new TextBlock { Id = Guid.Parse("14c75ba9-626d-4443-9332-8b66bec7769b"), Type = TextBlockType.Text, Text = "The new movement is as fast as your standard Speed; for example, if you have a 30-foot Speed, you can gain a 30-foot climb Speed. If your inherent animal doesn’t typically have a specific type of Speed, you can’t gain it with this feat. If your inherent animal doesn’t typically have a climb, fly, or swim Speed, your Speed increases by 10 feet instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5b34a94d-c99a-40f3-9907-6828f44ffb08"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
