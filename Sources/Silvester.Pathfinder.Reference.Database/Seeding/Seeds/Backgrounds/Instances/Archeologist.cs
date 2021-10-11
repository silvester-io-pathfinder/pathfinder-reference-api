using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Archeologist : Template
    {
        public static readonly Guid ID = Guid.Parse("ae217709-be61-47a8-b835-e2da36eb4556");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Archeologist",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1e0c5636-a810-4446-adab-a97594123e4e"), Type = TextBlockType.Text, Text = "You've excavated enough sites to know that ancient civilizations aren't lost; they're merely buried and waiting for the right scholar to unearth them and tell their story. You might have worked as a laborer or local guide before learning formal archaeological techniques." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("4138198e-0f8d-409f-9d24-8b15ecc94157"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("e7d8e459-fc17-487b-842f-d98c1b3f7a8f"), StatId = Stats.Instances.Constitution.ID },
                    new StatEffectBinding{Id = Guid.Parse("d5711480-ac7f-4b1e-9409-65f46ff1a67c"), StatId = Stats.Instances.Intelligence.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("4ec249fe-6607-4eb7-b606-40ef057c51cf")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("bf1cbc4a-c710-409e-b1c9-5d55b997c5cd"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Society.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("9d285365-5283-4f39-bca5-dbb1def34cfd"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Architecture.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("d8c5ce7d-a344-4547-baa3-929d1bc35319"),
                FeatId = Feats.General.AdditionalLoreFeat.ID,
                Restrictions = "Must be related to an ancient culture or the history of a culture you've studied (such as Azlanti Lore or Osirian History Lore)."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("22721aed-8015-45b1-8bb2-c914c7c24f44"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 6
            };
        }
    }
}
