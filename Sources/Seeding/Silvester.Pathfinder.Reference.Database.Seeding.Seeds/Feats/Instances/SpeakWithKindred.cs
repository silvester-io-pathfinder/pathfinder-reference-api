using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpeakWithKindred : Template
    {
        public static readonly Guid ID = Guid.Parse("4310dfd2-3c58-4cdb-b0e5-24758b6a57e5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Speak With Kindred",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("65633799-4872-4ef9-b26f-32efc161ee23"), Type = TextBlockType.Text, Text = $"You have a connection with creatures that share your physiology." };
            yield return new TextBlock { Id = Guid.Parse("5ba0cfc6-7559-452c-ba18-6cd7ad997670"), Type = TextBlockType.Text, Text = $"You can ask questions of, receive answers from, and use the Diplomacy skill with plants or fungi that match your leshy heritage. Generally, fungus leshies can speak to mushrooms and fungi; gourd leshies can speak to gourds, melons, and similar fruiting plants; leaf leshies can speak with deciduous trees; and vine leshies can speak with vines and climbing plants. The GM determines which plants or fungi count for this ability." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9aa22e0d-8cdb-4b7d-b0c2-5ed34b990948"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
