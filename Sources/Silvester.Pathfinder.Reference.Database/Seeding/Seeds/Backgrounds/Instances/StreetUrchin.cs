using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class StreetUrchin : Template
    {
        public static readonly Guid ID = Guid.Parse("09e50ee9-5dc2-4490-8b24-091cbd72294e");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Street Urchin",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5650a0b0-969b-4f47-87e9-9fc0f26b4ee9"), Type = TextBlockType.Text, Text = "You eked out a living by picking pockets on the streets of a major city, never knowing where you�d find your next meal. While some folk adventure for the glory, you do so to survive." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("a4f88770-ec28-48a7-a91e-dae8d455dfa8"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("c095ea12-61aa-49ee-abfa-da5dc4fc6bfc"), StatId = Stats.Instances.Dexterity.ID },
                    new StatEffectBinding{Id = Guid.Parse("a573ba47-e106-4e55-a9a9-6828a7de20fc"), StatId = Stats.Instances.Constitution.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("ae787cec-902c-4486-8178-64d8eca0871c")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("6fca3ba7-ee80-4349-bf96-14c5292b31f3"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Thievery.ID
            };

            yield return new LoreCategoryEffect
            {
                Id = Guid.Parse("b0d4dc5b-4ff3-49af-b788-cae40c0d4306"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreCategoryId = LoreCategories.Instances.Settlements.ID,
                Restrictions = "The chosen Lore skill must be related to the settlement you lived in as a street urchin (such as Absalom Lore or Magnimar Lore)."
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("27d19126-b0a0-4204-a5a7-c76f1c06ed4b"),
                FeatId = Feats.General.PickpocketFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20e84e57-638d-4bad-b737-a17dad02695d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 64
            };
        }
    }
}
