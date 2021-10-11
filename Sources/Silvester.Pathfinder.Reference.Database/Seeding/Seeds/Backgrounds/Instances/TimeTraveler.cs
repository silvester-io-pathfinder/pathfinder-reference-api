using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class TimeTraveler : Template
    {
        public static readonly Guid ID = Guid.Parse("0214d161-361e-456c-84dd-0a10ab1be7d2");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Time Traveler",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e579f108-7e23-447a-b127-6b5bf9c00b7b"), Type = TextBlockType.Text, Text = "You come from a different time. Whether by your own doing or a terrible accident, powerful magic has resulted in you coming to this time from the future or from the past, but you are unable to return. You might be from New Thassilon, an entire nation of time travelers." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("0b0d61d0-0041-40ca-94b8-b81effeeec7d"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("6012c804-55b2-4503-86c3-b1b61a0b222f"), StatId = Stats.Instances.Dexterity.ID },
                    new StatEffectBinding{Id = Guid.Parse("7659ed91-70a4-47c6-a584-661b7a2ad0db"), StatId = Stats.Instances.Intelligence.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("9f828174-220e-4bec-9a4b-ac2f91cacd64")
            };

            yield return new FreeLoreEffect
            {
                Id = Guid.Parse("e21133fe-5a63-4a90-8b61-fd077508066e"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                Restrictions = "The chosen Lore skill must be related to your own time."
            };

            yield return new FreeLoreEffect
            {
                Id = Guid.Parse("93a0e512-a50c-4f95-bec1-0bfe359779d5"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                Restrictions = "The chosen Lore skill must be related to your own time."
            };

            yield return new FreeLoreEffect
            {
                Id = Guid.Parse("f4a899fd-6d52-4f4d-993e-30b1de69329b"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                Restrictions = "The chosen Lore skill must be related to your own time."
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("91fbfaa0-06c9-4cb8-873e-f05fca096488"),
                FeatId = Feats.Special.BendTimeFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d408af42-4ba3-4a45-9ff4-db1b410c0da7"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 31
            };
        }
    }
}
