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
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("")); 
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Zevgavizeb.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.RaveningsDesperation.ID);
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
