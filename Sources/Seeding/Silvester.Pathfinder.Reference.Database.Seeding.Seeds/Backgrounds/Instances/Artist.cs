using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

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

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("9f52a26c-aa16-4470-9e08-41b7ed47e63e"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("037ca139-3378-4c25-bbda-7f95b3f16d52"), Stats.Instances.Dexterity.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("1643b862-6008-4ec3-a9a0-0be2ba661b37"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("829f2ee0-5e09-450b-be72-8aa773fa9a36"));
            builder.GainSpecificSkillProficiency(Guid.Parse("a31c867b-798d-4bb2-bbb9-8d74df79f009"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("44b6f106-8bf8-43bf-bcb5-d84b432784dc"), Proficiencies.Instances.Trained.ID, Lores.Instances.Art.ID);
            builder.GainSpecificFeat(Guid.Parse("4c5814b4-a47b-489e-a81e-81a3afcc1df7"), Feats.Instances.SpecialtyCrafting.ID);
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
