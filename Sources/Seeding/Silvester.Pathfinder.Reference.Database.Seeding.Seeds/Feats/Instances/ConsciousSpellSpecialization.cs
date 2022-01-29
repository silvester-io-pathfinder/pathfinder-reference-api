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
    public class ConsciousSpellSpecialization : Template
    {
        public static readonly Guid ID = Guid.Parse("b9b3633e-708e-4ca7-8541-903adddf386c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Conscious Spell Specialization",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eeefd0a7-b6dc-4604-a681-e465a402e0e3"), Type = TextBlockType.Text, Text = $"Your practice with the spells of your conscious mind allows you to cast them even more than normal. You gain an additional spell slot of 1st, 2nd, 3rd, and 4th levels. You can use these spell slots to cast only spells granted by your conscious mind." };
            yield return new TextBlock { Id = Guid.Parse("db126d3f-76b3-41b7-ae55-c8ef10b4facc"), Type = TextBlockType.Text, Text = $"At 18th level, you also gain an additional 5th-level spell slot with the same restrictions." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("29e35efe-c4dd-4468-92e6-26fb621e3589"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
