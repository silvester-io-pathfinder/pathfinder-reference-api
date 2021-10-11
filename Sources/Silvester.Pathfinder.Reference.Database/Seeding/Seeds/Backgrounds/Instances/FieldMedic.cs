using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class FieldMedic : Template
    {
        public static readonly Guid ID = Guid.Parse("9431fb9a-a526-4b72-afe3-f5fc9cb75100");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Field Medic",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("79ddfa2e-bf7d-46b9-8927-460ede3a2b1c"), Type = TextBlockType.Text, Text = "In the chaotic rush of battle, you learned to adapt to rapidly changing conditions as you administered to battle casualties. You patched up soldiers, guards, or other combatants, and learned a fair amount about the logistics of war." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("9dc2b672-85e5-4692-a234-40b9841c6820"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("f5f3d3de-d8ff-457c-9960-3c6a9665a6a6"), StatId = Stats.Instances.Constitution.ID },
                    new StatEffectBinding{Id = Guid.Parse("77ea70b2-b522-4e9e-85f1-315e96171b1a"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("7b3886a3-ff12-4fb0-be1d-a8005e07a444")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("4facbc7d-9b10-4245-9882-5b64c5940db1"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Medicine.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("dacd10c4-f194-427c-ba68-d92bea977a7f"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Warfare.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("9b687978-ee00-4154-b8ac-9ee2027ea5c4"),
                FeatId = Feats.General.BattleMedicineFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e41e95bd-5ff0-44a9-84e1-c1dc28ec00bf"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 62
            };
        }
    }
}
