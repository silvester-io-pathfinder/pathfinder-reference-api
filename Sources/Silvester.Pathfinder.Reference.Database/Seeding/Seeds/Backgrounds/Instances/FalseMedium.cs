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
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.FortuneTelling.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.DeceptiveWorship.ID);
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
