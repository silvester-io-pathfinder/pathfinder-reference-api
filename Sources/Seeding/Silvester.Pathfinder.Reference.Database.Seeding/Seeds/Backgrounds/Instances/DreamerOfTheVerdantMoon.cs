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
    public class DreamerOfTheVerdantMoon : Template
    {
        public static readonly Guid ID = Guid.Parse("e8623506-6e61-4141-9a74-f04e325e2bbb");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Dreamer of the Verdant Moon",
                RarityId = Rarities.Instances.Uncommon.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("998ff677-3d4a-4033-90ae-2bc109c2990c"), Type = TextBlockType.Text, Text = "You spent your early days in the aftermath of one of the great ravenings. You survived thanks to your resourcefulness and perhaps your patron's favor and were blessed with skills and drive thereafter, but you must always hold to his standards, lest the hunger from the depths seek you out once again." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("49eb0bd5-c5c8-4c3b-83ca-eb3f3c8d25f6"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("4c1342e2-af4a-44e7-8fdb-cd03919a9551"), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("eab7c899-dfcc-4b5a-9f0d-70bce60fe42d"), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("d7040ea5-66f1-4f12-87fb-986657c7ca34")); 
            builder.GainSpecificSkillProficiency(Guid.Parse("1649c04a-8b4d-48e0-8687-b0e85e258710"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("8640e6c4-fcb9-4aba-8dcf-28ed53f9fd22"), Proficiencies.Instances.Trained.ID, Lores.Instances.Zevgavizeb.ID);
            builder.GainSpecificFeat(Guid.Parse("2e74427f-4b32-4fe4-8f73-e490c3562560"), Feats.Instances.RaveningsDesperation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("497e3e49-5f18-4317-bd1e-95bebc848a1f"),
                SourceId = Sources.Instances.Pathfinder153.ID,
                Page = 67
            };
        }
    }
}
