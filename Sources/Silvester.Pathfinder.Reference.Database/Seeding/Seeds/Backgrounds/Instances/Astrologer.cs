using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Astrologer : Template
    {
        public static readonly Guid ID = Guid.Parse("17db4a2a-cd6c-4516-b39e-60fff10f5ba3");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Astrologer",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b3b686ba-e30a-455e-9da1-089063bceb33"), Type = TextBlockType.Text, Text = "Astrologers look to the stars for signs and portents, using their positions to chart courses for those living beneath them. As the celestial spheres move, so does fate itself. You studied the stars and learned to divine your path based on their guidance. Whether the stars directly called you to a life of adventure or you use the stars to guide your wanderlust, you're living out the stars' guidance in a life of adventure." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("f7163ce5-9d99-4c7d-8daf-67d1e90fa175"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("aad194bf-52cb-4a18-a6ab-4eb529dafe66"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("7ec55d6d-9a12-4572-af86-fff6e6b4fe25"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("925377c3-854f-4bb3-9ff8-29f24a491fd8")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("9d4016a6-eddf-4254-93ba-73ac2e8fdde6"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Occultism.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("4aa1c940-72fb-4cee-9f62-c2df87d12786"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Astrology.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("bee86dc3-e116-4ee9-992a-3e37fa2dd464"),
                FeatId = Feats.General.OddityIdentificationFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dd0bebd6-de33-41b9-8f1f-ce9658340802"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 28
            };
        }
    }
}
