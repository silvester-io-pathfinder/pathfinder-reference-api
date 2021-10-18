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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("3dfd5968-5728-4c6b-bf02-0cc3de7d9d4c"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("7a6a8a31-0b2b-4240-8950-8042fbbcf47d"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("936b76c0-daf7-4548-b926-ca10026a9c27"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("5f06c56d-a6bb-4926-b25e-13adcd5904f1")
            };

            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse("8b91d8cb-92f6-4782-8f94-0f15a14a3e4b"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Occultism.ID
            };

            yield return new GainSpecificLoreProficiencyEffect
            {
                Id = Guid.Parse("00121594-c991-429a-a0d0-acb3f548b9ac"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.FortuneTelling.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("e63802c3-5c84-438f-a521-38529c228a4e"),
                FeatId = Feats.General.DeceptiveWorshipFeat.ID
            };
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
