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
    public class FalseMedium : Template
    {
        public static readonly Guid ID = Guid.Parse("42f41d3b-be51-48b0-958d-b2f119cf9470");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "False Medium",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("119d4ac4-9f89-4019-af2f-4203595eb4f6"), Type = TextBlockType.Text, Text = "There are people in this world who possess the ability to pierce the veil between the world of the living and the world of the dead, allowing them to communicate with spirits. You... are not one of them. But you know enough about the occult, as well as cold reading tricks and various practices from local religions, to scam your way into people's coinpurses. Unlike a through-and-through charlatan, there's some real occult methodology behind your flimflam, but that's likely cold comfort to the people you swindle. Whether you decided to take a more righteous path, were caught and pledged to make it right, or still slip in a few 's'ances' between adventures, you've taken to an adventuring lifestyle as you move from place to place." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("0f62d569-cabe-4351-944e-6e2cebd31571"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("2be48663-cfe3-4f7b-8da9-8bdbeea310fd"), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("de433501-35d0-4e6f-b73f-f0342bb0dbc5"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("3e94db61-4f0d-4cdf-ba2a-ed2fd8bb61b0"));
            builder.GainSpecificSkillProficiency(Guid.Parse("19d3bf9b-cbba-43a1-8124-0a6b0cc56f6b"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("9dea29e3-2c8a-4715-8a05-b47c045e4c24"), Proficiencies.Instances.Trained.ID, Lores.Instances.FortuneTelling.ID);
            builder.GainSpecificFeat(Guid.Parse("914adf03-f713-4424-8495-630a557cb222"), Feats.Instances.DeceptiveWorship.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab17a8fa-66dd-49dc-a2a6-10ff5693a06e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 28
            };
        }
    }
}
