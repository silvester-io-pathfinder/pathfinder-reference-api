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
    public class MercilessRend : Template
    {
        public static readonly Guid ID = Guid.Parse("ab1ae656-288f-4c9e-907e-9a8d0c06481b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Merciless Rend",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e0071eb1-c6e5-438b-976c-5d0f683939d9"), Type = TextBlockType.Text, Text = $"Your eidolon rends its foes. It automatically deals the damage from its secondary attack to the enemy." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("fb068f94-3250-45e3-9d7a-a7a499a3f60d"), Traits.Instances.Eidolon.ID);
            builder.Add(Guid.Parse("6668e871-7276-4d9b-be07-a8d5021e59a1"), Traits.Instances.Evolution.ID);
            builder.Add(Guid.Parse("bdc7f7d5-2e79-4c86-9534-e3f270037cb8"), Traits.Instances.Summoner.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d480b4ac-6cde-46a2-8855-c701e8c3cbe4"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
