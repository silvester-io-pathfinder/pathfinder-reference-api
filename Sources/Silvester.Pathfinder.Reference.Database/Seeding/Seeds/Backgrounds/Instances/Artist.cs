using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Artist : Template
    {
        public static readonly Guid ID = Guid.Parse("d3992c4b-155d-475f-8a26-9995ce13e058");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Artist",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b8b4e9f9-41a3-4fa2-9326-df75c5a497e1"), Type = TextBlockType.Text, Text = "Your art is your greatest passion, whatever form it takes. Adventuring might help you find inspiration, or simply be a way to survive until you become a world-famous artist." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("ea09c6d4-cd84-4b3b-a70a-231e71c7cc07"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("e9119d2e-7193-4711-93a0-159a6ddd1e1c"), StatId = Stats.Instances.Dexterity.ID },
                    new StatEffectBinding{Id = Guid.Parse("d1b3ee64-3ce7-4b91-833a-79e0dec42632"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("d364f482-6f77-4c86-9f8a-dab58656433e")
            };

            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse("8e20d893-ca13-4293-aa8b-2cd850e79fe7"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Crafting.ID
            };

            yield return new GainSpecificLoreProficiencyEffect
            {
                Id = Guid.Parse("5074e9f9-7b1a-4788-9241-153ba813ee07"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Art.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("1fde9d54-0b83-4464-a686-63c95135d4d8"),
                FeatId = Feats.General.SpecialtyCraftingFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("44a4f77d-c507-409e-b310-1f0a27fd83a5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 60
            };
        }
    }
}
