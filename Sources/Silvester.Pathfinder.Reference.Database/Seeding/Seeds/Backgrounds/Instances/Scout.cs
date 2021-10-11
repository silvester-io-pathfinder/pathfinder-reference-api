using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Scout : Template
    {
        public static readonly Guid ID = Guid.Parse("a6116a94-0555-4882-969e-c7b245e2b6b3");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Scout",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7ea32318-8408-4144-95fd-8b852ad3d83b"), Type = TextBlockType.Text, Text = "You called the wilderness home as you found trails and guided travelers. Your wanderlust could have called you to the adventuring life, or perhaps you served as a scout for soldiers and found you liked battle." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("1e8701a0-e8e3-4c94-9a34-75d028a96d19"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("bafca9a5-3002-4891-b3ef-11ae8ce39607"), StatId = Stats.Instances.Dexterity.ID },
                    new StatEffectBinding{Id = Guid.Parse("ee2706b1-7ad8-4f44-892f-1a25823709dd"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("7656c4b8-e63b-483e-9fa6-641fedf5ae4b")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("6d041e53-7541-45e0-bb8e-71fd17d00d72"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Survival.ID
            };

            yield return new LoreCategoryEffect
            {
                Id = Guid.Parse("fea108a8-ce19-4f91-9c0e-7a43e50775d4"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreCategoryId = LoreCategories.Instances.Terrains.ID,
                Restrictions = "The chosen Lore skill must relate to a terrain you scouted in (such as Forest Lore or Cavern Lore)."
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("5f8e9380-042e-4b93-ab4f-5b832ac6394c"),
                FeatId = Feats.General.ForagerFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9cd0aeea-0c78-4124-b30b-eb06751d37b3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 64
            };
        }
    }
}
