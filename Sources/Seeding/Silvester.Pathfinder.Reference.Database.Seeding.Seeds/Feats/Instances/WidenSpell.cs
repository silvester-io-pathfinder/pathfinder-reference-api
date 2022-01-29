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
    public class WidenSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("4d5898c6-4454-4702-a3ca-69d85f00685b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Widen Spell",
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
            yield return new TextBlock { Id = Guid.Parse("f6fd17a5-c6d3-4db7-b486-39bfce6e3ca0"), Type = TextBlockType.Text, Text = $"You manipulate the energy of your spell, causing it to affect a wider area. If the next action you use is to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} that has an area of a burst, cone, or line and doesn't have a duration, increase the area of that spell. Add 5 feet to the radius of a burst that normally has a radius of at least 10 feet (a burst with a smaller radius isn't affected). Add 5 feet to the length of a cone or line that is normally 15 feet long or smaller, and add 10 feet to the length of a larger cone or line." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("05de3eb2-55f2-4755-a6ba-0e7ea331487b"), Traits.Instances.Druid.ID);
            builder.Add(Guid.Parse("87d1fb3a-c99c-4d16-88c4-ca3aa0e422c1"), Traits.Instances.Manipulate.ID);
            builder.Add(Guid.Parse("c4cc19a0-a906-4bf6-9f09-52efb16ac2e3"), Traits.Instances.Metamagic.ID);
            builder.Add(Guid.Parse("750888ce-eec3-439a-a7d9-883a4d343252"), Traits.Instances.Oracle.ID);
            builder.Add(Guid.Parse("9b72b6d7-a9a6-4dd9-942d-005383d560f2"), Traits.Instances.Sorcerer.ID);
            builder.Add(Guid.Parse("05f95871-40d3-4262-ae51-4c87344648ec"), Traits.Instances.Witch.ID);
            builder.Add(Guid.Parse("71aebb80-3c3a-45f4-8535-ac102090cd19"), Traits.Instances.Wizard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b230cb29-9970-43ec-aa1f-8de3f31ddca1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
