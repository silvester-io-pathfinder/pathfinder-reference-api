using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PrideInArms : Template
    {
        public static readonly Guid ID = Guid.Parse("b277ca8f-5deb-45d1-970e-ac8b2a6c895b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pride in Arms",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally within 30 feet brings a foe to 0 Hit Points.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8e3e796f-4493-4d95-ae7d-6afcb14dd3e7"), Type = TextBlockType.Text, Text = "With a shout of triumph, you grant inspiration to an ally fight on. The triggering ally gains temporary Hit Points equal to their Constitution modifier until the end of their next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c7df542-9591-4508-a53f-c61912cc0946"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
