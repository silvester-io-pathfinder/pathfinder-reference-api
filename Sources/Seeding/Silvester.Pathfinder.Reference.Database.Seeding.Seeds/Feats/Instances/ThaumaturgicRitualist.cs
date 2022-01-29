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
    public class ThaumaturgicRitualist : Template
    {
        public static readonly Guid ID = Guid.Parse("bdec6687-3f05-4e5b-a403-b0e7d1d092a3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Thaumaturgic Ritualist",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("59e017a6-e9ab-408f-9087-5572477f8895"), Type = TextBlockType.Text, Text = $"Your studies into the supernatural have resulted in an especially strong knowledge of rituals. You gain a +2 circumstance bonus to all primary checks to perform a ritual. You learn two uncommon rituals with a level no higher than half your level; you must meet all prerequisites for casting the ritual to choose it. At 8th level and every 4 levels thereafter, you learn another uncommon ritual with a level no higher than half your level and for which you meet the prerequisites. You can cast these as the primary caster, but you can't teach them to anyone else or allow someone else to serve as primary caster unless they know the ritual as well." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2abaa808-41d8-4b42-b3fc-3cc9c0e816c8"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
