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
        public static readonly Guid ID = Guid.Parse("6b0b94db-7af7-4e54-ad1a-d9b964b5bf1d");

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
            yield return new TextBlock { Id = Guid.Parse("3ca0cfcd-87a0-46f6-b6e4-4f660b7c4530"), Type = TextBlockType.Text, Text = "Transformed by uncontrolled magic, you originated in the Mana Wastes or another region similarly devastated by uncontrolled magic. Due to your toughened or redundant organs, the DC for your checks to recover from persistent bleed damage is 10 instead of 15, and it's reduced to 5 instead of 10 if you have particularly effective assistance recovering from the persistent damage." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("94fd9970-0837-4da9-a58f-69159573a1ae"), "The DC for your checks to recover from persistent bleed damage is 10 instead of 15, and it's reduced to 5 instead of 10 if you have particularly effective assistance recovering from the persistent damage.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("38fcc976-959c-452f-8790-802183c4d868"),
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
