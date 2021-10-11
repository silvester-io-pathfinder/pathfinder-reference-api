using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Noble : Template
    {
        public static readonly Guid ID = Guid.Parse("44a42ca6-d27c-4200-af75-4114a2f4f58d");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Noble",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b005e333-5c6b-4ad2-bfd1-9500704e2181"), Type = TextBlockType.Text, Text = "To the common folk, the life of a noble seems one of idyllic luxury, but growing up as a noble or member of the aspiring gentry, you know the reality: a noble's lot is obligation and intrigue. Whether you seek to escape your duties by adventuring or to better your station, you have traded silks and pageantry for an adventurer's life." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("8e42ec44-ad9a-4f61-b6a3-8e27298cb356"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("6eb1c79a-b394-471e-8b1b-8bd7dfb74a95"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("0911d390-eb2b-41f5-b9b9-0f4c21b0e4a7"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("2d1caf79-1621-4440-aee7-86e81f8ea792")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("ef2aa6d9-ebf0-4b99-92af-2b8bd6dd5b6f"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Society.ID
            };

            yield return new ChoiceEffect
            {
                Id = Guid.Parse("c5ce8084-6ad2-4815-a332-b96c1ce6ef3a"),
                Choices = new Effect[]
                {
                    new LoreEffect { Id = Guid.Parse("2f35182c-db6d-48a4-bf4c-4ccd500af216"), ProficiencyId = Proficiencies.Instances.Trained.ID, LoreId = Lores.Instances.Genealogy.ID },
                    new LoreEffect { Id = Guid.Parse("51d93ed0-0730-43fb-90ad-6310c087668d"), ProficiencyId = Proficiencies.Instances.Trained.ID, LoreId = Lores.Instances.Heraldry.ID }
                }
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("5b7bcfdc-fcc8-45ad-8ead-1591a138beef"),
                FeatId = Feats.General.CourtlyGracesFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("15629c62-c9b3-480b-9a1e-5e18bd8f0dff"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 63
            };
        }
    }
}
