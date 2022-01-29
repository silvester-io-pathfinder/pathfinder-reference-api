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
    public class PushingAttack : Template
    {
        public static readonly Guid ID = Guid.Parse("d481ae37-f61c-490c-9fc9-4b3f06592fca");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pushing Attack",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2c40107f-d31a-4f4d-a54e-6b20c704288d"), Type = TextBlockType.Text, Text = $"Your eidolon has an attack that pushes away enemies. Choose one of the eidolon's unarmed attacks with the {ToMarkdownLink<Models.Entities.Trait>("shove", Traits.Instances.Shove.ID)} trait. It gains the Push action (Bestiary pg. 343) for that attack." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("43107fbf-cd8e-4f24-8079-9963096b8094"), Traits.Instances.Evolution.ID);
            builder.Add(Guid.Parse("39c1ac84-4f61-42a9-9868-53230b70c7b3"), Traits.Instances.Summoner.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ff6bd1a-cb20-4a96-b0e6-b0a9dcbe5c10"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
