using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Guard : Template
    {
        public static readonly Guid ID = Guid.Parse("5ea02322-252b-4991-8cd9-ca0f14c4349d");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Guard",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("118502a0-15e4-4719-b27a-26532fcb0279"), Type = TextBlockType.Text, Text = "You served in the guard, out of either patriotism or the need for coin. Either way, you know how to get a difficult suspect to talk. However you left the guard, you might think of adventuring as a way to use your skills on a wider stage." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("5bd2df60-8081-448d-9d37-f5b9e9474424"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("b3445771-d97d-4ca5-9322-f1f63c0a18ba"), StatId = Stats.Instances.Strength.ID },
                    new StatEffectBinding{Id = Guid.Parse("36af1bbe-4d60-4440-9aae-ca01f28b70eb"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("dac82bd1-9b85-47d7-b037-7f32622ba14c")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("07c94b59-74bd-4868-b072-0df8f5d4a4ea"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Intimidation.ID
            };

            yield return new ChoiceEffect
            {
                Id = Guid.Parse("1291e39e-a84d-46ef-a0dc-e32db9a3e0da"),
                Choices = new Effect[]
                {
                    new LoreEffect { Id = Guid.Parse("9a2d4f34-351f-42ca-8167-363b7e793804"), ProficiencyId = Proficiencies.Instances.Trained.ID, LoreId = Lores.Instances.Legal.ID },
                    new LoreEffect { Id = Guid.Parse("174f5acf-d298-4263-b538-cdb7a3a21fed"), ProficiencyId = Proficiencies.Instances.Trained.ID, LoreId = Lores.Instances.Warfare.ID },
                }
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("edf6528a-49bd-4de7-b3d8-f3a0b6c69b66"),
                FeatId = Feats.General.QuickCoercionFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0d0d6ac9-91f5-464f-b74a-e27304fd7db9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 62
            };
        }
    }
}
