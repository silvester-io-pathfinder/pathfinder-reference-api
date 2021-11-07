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
    public class CreatedFleshwarp : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Created Fleshwarp"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You were created through occult or alchemical processes, such as being grown in a vat or stitched together from the body parts of other creatures by a scientist in Ustalav. Your manufactured body is durable; you don't need to eat and can't starve. You gain a +2 circumstance bonus to saving throws against diseases." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse(""), "Your manufactured body is durable; you don't need to eat and can't starve.");
            builder.GainSpecificTraitAnySavingThrowCircumstanceBonus(Guid.Parse(""), Traits.Instances.Disease.ID, bonus: 2);
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
