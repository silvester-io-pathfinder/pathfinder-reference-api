using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class DarkFieldsKitsune : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Dark Fields Kitsune"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You can exert your unsettling presence to subtly Demoralize others. When you do, Demoralize loses the auditory trait and gains the visual trait, and you don't take a penalty when you attempt to Demoralize a creature that doesn't understand your language. You also gain the Invigorating Fear reaction. Your alternate form is a fox, which has the statistics of 1st-level pest form." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse(""), "You can exert your unsettling presence to subtly Demoralize others. When you do, Demoralize loses the auditory trait and gains the visual trait, and you don't take a penalty when you attempt to Demoralize a creature that doesn't understand your language.");
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.InvigoratingFear.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 123
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Kitsune.ID;
        }
    }
}
