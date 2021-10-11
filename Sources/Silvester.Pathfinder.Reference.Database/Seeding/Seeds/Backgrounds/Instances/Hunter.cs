using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Hunter : Template
    {
        public static readonly Guid ID = Guid.Parse("430d7860-f18e-47da-b533-d8690ecff734");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Hunter",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("99a39f7d-b29a-4f2b-8aa1-1f6bb2414427"), Type = TextBlockType.Text, Text = "You stalked and took down animals and other creatures of the wild. Skinning animals, harvesting their flesh, and cooking them were also part of your training, all of which can give you useful resources while you adventure." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("db21e421-3abe-4ab9-8d98-a70beb227e81"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("9e9c0bb1-18af-4e26-89ec-3f312ef63ac0"), StatId = Stats.Instances.Dexterity.ID },
                    new StatEffectBinding{Id = Guid.Parse("b719f7ae-cccc-4c8b-ac58-b6cce4554cea"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("e8bcd6a5-8a92-4312-91c8-a5270017715a")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("fb35e3bd-0064-4502-93f3-09be93473b8b"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Survival.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("df9c2453-3043-4526-9ec3-da2c32b117f2"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Tanning.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("d503f8de-006a-4efc-8499-c2b1d1d957e7"),
                FeatId = Feats.General.SurveyWildlifeFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1b8ebfd7-e85c-49bb-ae9d-82a0e2b8bd7a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 62
            };
        }
    }
}
