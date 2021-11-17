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
    public class Charlatan : Template
    {
        public static readonly Guid ID = Guid.Parse("839f2956-cc7d-452a-83b5-9aa19fbba70f");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Charlatan",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("0f1a7ea5-36fe-4bb9-9446-f23e026094f0"), Type = TextBlockType.Text, Text = "You traveled from place to place, peddling false fortunes and snake oil in one town, pretending to be royalty in exile to seduce a wealthy heir in the next. Becoming an adventurer might be your next big scam or an attempt to put your talents to use for a greater cause. Perhaps it's a bit of both, as you realize that after pretending to be a hero, you've become the mask." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("7167bfba-298e-41eb-a11d-61f66354267b"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("40e85727-753d-4aa8-8919-ac0eeade2557"), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("f2eec107-5a40-404c-ae81-66a19e9f90fb"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("bb0c6cf8-b92c-4bfa-a83f-cc8f78cb934a"));
            builder.GainSpecificSkillProficiency(Guid.Parse("9d4fe234-5700-439c-9892-11ac62d08c31"), Proficiencies.Instances.Trained.ID, Skills.Instances.Deception.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("6ec9bd63-59b9-492f-92b7-b402e19b0ab5"), Proficiencies.Instances.Trained.ID, Lores.Instances.Underworld.ID);
            builder.GainSpecificFeat(Guid.Parse("5b6bb660-b35a-44f4-8786-916d8c0e32ef"), Feats.Instances.CharmingLiar.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b9daae1a-2f0f-4fdb-a655-ebc69426b589"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 61
            };
        }
    }
}
