using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class PlantWhisperer : Template
    {
        public static readonly Guid ID = Guid.Parse("2d428abd-d8fa-4d36-8a86-bbdabd56d36e");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Plant Whisperer",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e9f99e6d-196e-4325-baf7-129cd4b3ee90"), Type = TextBlockType.Text, Text = "You've always had a green thumb, allowing you to care for plants that others found too difficult to grow and tend with a skill that borders on the magical. As you travel, you encounter all sorts of new plants and plant creatures, allowing you to expand your horizons and deepen your understanding of flora." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("8662c35b-22b0-4ca9-bd68-1745782e3e58"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("fbcf75d4-037a-4abc-b8b1-3e478f4d3c98"), StatId = Stats.Instances.Wisdom.ID },
                    new StatEffectBinding{Id = Guid.Parse("2aaa056a-78b6-401f-8b01-e3415332d85b"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("68667128-ba39-468c-8541-d6f50eaa397c")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("e4d9d5ab-1683-45b0-a031-0d3df029fb54"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Nature.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("ee5fdcd1-5439-4354-a89a-408bdf075006"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Plant.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("69f8046a-b786-4456-b72a-52553637c8c2"),
                FeatId = Feats.General.NaturalMedicineFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("38120214-4000-44d8-8906-fa6a708f2219"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 29
            };
        }
    }
}
