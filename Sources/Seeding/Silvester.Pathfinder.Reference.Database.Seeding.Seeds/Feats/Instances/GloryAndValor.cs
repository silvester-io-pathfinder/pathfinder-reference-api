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
    public class GloryAndValor : Template
    {
        public static readonly Guid ID = Guid.Parse("ed3867bc-3395-4da6-9ce2-a08160abdb30");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Glory and Valor!",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9e7fb920-1971-4c3f-a569-b86dda68e157"), Type = TextBlockType.Text, Text = $"You are descended from the einherji, the worthy warriors of chaos. You call upon your ascendant blood with a mighty cry that fills you with a revitalizing energy for 1 minute or until you critically fail a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, whichever comes first. For the duration, the first time each round you successfully {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} a creature of your level or higher, you regain Hit Points equal to half your level." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("b124de8f-80fe-499b-9f39-55b1eb30b466"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("b5121153-7777-480a-bdc7-3a93772457db"), Traits.Instances.Ganzi.ID);
            builder.Add(Guid.Parse("f9f222f3-39cd-4562-919b-3ad9e0d603df"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("86cd986c-7b8f-4ba1-989e-b400be0588c1"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("b76ef1ee-dbd6-4574-a92d-153f00206569"), Traits.Instances.Primal.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8fb3323a-b0e8-4b6f-a6ab-1e14a7a3c12c"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
