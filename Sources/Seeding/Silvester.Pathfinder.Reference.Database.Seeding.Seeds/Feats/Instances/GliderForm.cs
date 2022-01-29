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
    public class GliderForm : Template
    {
        public static readonly Guid ID = Guid.Parse("356400f1-8d52-4822-afb9-e62c69115805");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Glider Form",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("acf46677-b940-4400-ad63-390f8500dfe5"), Type = TextBlockType.Text, Text = $"Your eidolon evolves wings, a buoyant body, or some other means to control descent. It glides slowly toward the ground, 5 feet down and up to 25 feet forward through the air. As long as it spends at least 1 action gliding each round and has not yet reached the ground, it remains in the air at the end of your turn." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("5d0b7a92-1b48-4389-86cd-b035566a7d75"), Traits.Instances.Eidolon.ID);
            builder.Add(Guid.Parse("93bbdbea-23c4-4454-8c8d-56064f9fab96"), Traits.Instances.Evolution.ID);
            builder.Add(Guid.Parse("92ed8bba-5b31-4fef-9c4a-8d37485f1908"), Traits.Instances.Move.ID);
            builder.Add(Guid.Parse("da02ab35-e596-4d8c-bed4-c39f14e1ffe4"), Traits.Instances.Summoner.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fcfaac55-8f8d-45ff-a032-dd3a4c20cec8"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
