using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("282c03fd-af98-41a9-9d1b-f9e530c135ea"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("9fe1520f-ef07-44fe-89c8-e06738fd7dae"), StatId = Stats.Instances.Strength.ID },
                    new StatEffectBinding{Id = Guid.Parse("b69814e2-8a9d-444a-839d-c7212319f60f"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("13edbec9-abbd-4e14-aee9-4a64a287a3b7")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("20123d23-2bce-4a9f-b2dd-44d803612bff"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Survival.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("aef26674-af0c-434c-b9c4-469c83513ff2"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Zevgavizeb.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("0aeb35db-61b1-43ac-a02f-b0db59a77247"),
                FeatId = Feats.Special.RaveningsDesperationFeat.ID
            };
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
