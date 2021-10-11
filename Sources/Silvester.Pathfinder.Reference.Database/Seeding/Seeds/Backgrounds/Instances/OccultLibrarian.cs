using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("c61da588-b3a1-4979-ad19-0f74bc41fd9d"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("f554e223-3d28-42f6-8b54-b7d994c6741e"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("940737da-d46f-4e9f-9aa0-7bdd15c27688"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("7d68b8cd-5fbe-4480-a099-6340756e93f0")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("8f9c1ce7-96d5-4b1a-a78f-9fe82d905163"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Occultism.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("291313ad-84c8-4b24-baab-4d616a3726cf"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Academia.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("15b9bfc1-c6ef-42f3-a63e-8d6f2b88d7a1"),
                FeatId = Feats.General.SchooledInSecretsFeat.ID
            };
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
