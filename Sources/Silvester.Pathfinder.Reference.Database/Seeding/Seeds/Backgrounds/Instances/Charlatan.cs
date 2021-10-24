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
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Deception.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Underworld.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.CharmingLiar.ID);
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
