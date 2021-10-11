using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class RootWorker : Template
    {
        public static readonly Guid ID = Guid.Parse("aa3084cf-28c8-47c8-8711-e759c62d6ba0");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Root Worker",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d8d13c87-5eb3-45b8-8903-98f0921c4d15"), Type = TextBlockType.Text, Text = "Some ailments can't be cured by herbs alone. You learned ritual remedies as well, calling on nature spirits to soothe aches and ward off the evil eye. Taking up with adventurers has given you company on the road, as well as protection from those who would brand you a fake'or worse." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("29bbaa13-c057-4c21-8139-836d5fe61576"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("74476036-1a54-4b87-a5c8-a32ec8f29afd"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("1cd81db4-4c45-4429-bfcf-6dfd629c55ee"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("62bfa888-8937-4d3e-9192-49537e13672c")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("3b8fff31-4656-4760-94c5-307464175d5c"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Occultism.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("9f306e1a-e08d-4d46-a166-937725c20972"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Herbalism.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("848d8b20-89f8-438c-828c-fbc33e473b7f"),
                FeatId = Feats.General.RootMagicFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e533f8d-006e-4d5f-bc06-b5d4ba993d92"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 49
            };
        }
    }
}
