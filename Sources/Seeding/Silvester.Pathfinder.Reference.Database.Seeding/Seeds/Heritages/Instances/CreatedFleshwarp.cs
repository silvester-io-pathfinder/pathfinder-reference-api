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
        public static readonly Guid ID = Guid.Parse("5e49ff1d-a0f2-4a2c-8ffe-2f34506b4d65");

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
            yield return new TextBlock { Id = Guid.Parse("5ba33a28-d166-4f93-9672-d81e074e62fe"), Type = TextBlockType.Text, Text = "You were created through occult or alchemical processes, such as being grown in a vat or stitched together from the body parts of other creatures by a scientist in Ustalav. Your manufactured body is durable; you don't need to eat and can't starve. You gain a +2 circumstance bonus to saving throws against diseases." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.Manual(Guid.Parse("da676d59-c413-4134-a3bb-ffe95683c6fa"), "Your manufactured body is durable; you don't need to eat and can't starve.");
            builder.GainSpecificTraitAnySavingThrowCircumstanceBonus(Guid.Parse("04e6774f-00c3-4d07-bc29-fdf2559b45f6"), Traits.Instances.Disease.ID, bonus: 2);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b1d1fa5d-4b85-4781-ac71-d8192d2fb066"),
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
