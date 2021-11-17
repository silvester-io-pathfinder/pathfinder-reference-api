using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class OccultLibrarian : Template
    {
        public static readonly Guid ID = Guid.Parse("ec224d3c-f51f-45c1-b39e-c03eb5e3e7cb");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Occult Librarian",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("dc4e649e-da94-44c7-96dd-9a336f9cb550"), Type = TextBlockType.Text, Text = "Hours spent reading numerous compendiums dedicated to various occult topics honed your knowledge of these more obscure magical arts. You might have taken to adventuring to finance your acquisition of rare tomes, to explore occult mysteries that can't be found in the pages of a book, or perhaps to put your skills to the test." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("a182e8b2-4aef-44e6-80ab-e03c21de65e5"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("ae13a972-f10e-49d7-a2ef-01b9307b7e33"), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("ba9912e3-bb89-4862-8ed1-8a117b2d8b7c"), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("6ddd61db-70ed-4a87-81b4-ad9aa2da0b26"));
            builder.GainSpecificSkillProficiency(Guid.Parse("0668fb84-f2fb-49e8-b68e-c2e549874ea7"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("58f9794b-369f-4b7c-83bb-976da89ee070"), Proficiencies.Instances.Trained.ID, Lores.Instances.Academia.ID);
            builder.GainSpecificFeat(Guid.Parse("82387154-9781-4d0c-b5f7-1bf4e7b97366"), Feats.Instances.SchooledInSecrets.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c5478d9-e99f-49b5-b975-b702dc0ca891"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 29
            };
        }
    }
}
