using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class MutatedFleshwarp : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Mutated Fleshwarp"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Transformed by uncontrolled magic, you originated in the Mana Wastes or another region similarly devastated by uncontrolled magic. Due to your toughened or redundant organs, the DC for your checks to recover from persistent bleed damage is 10 instead of 15, and it's reduced to 5 instead of 10 if you have particularly effective assistance recovering from the persistent damage." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse(""), "The DC for your checks to recover from persistent bleed damage is 10 instead of 15, and it's reduced to 5 instead of 10 if you have particularly effective assistance recovering from the persistent damage.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 91
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Fleshwarp.ID;
        }
    }
}
