using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Servant : Template
    {
        public static readonly Guid ID = Guid.Parse("bd4c13a6-175d-4eeb-9bf7-c688deda6f50");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Servant",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b383ea03-141a-4c90-ad77-f1f40b48ea8b"), Type = TextBlockType.Text, Text = "You held a role of servitude, waiting on nobles and engendering their trust as one of the confidantes of the household. You might have walked away on good terms, or perhaps you know dangerous secrets about your former masters. Regardless, you're adventuring for a change and finding that in this new role, the skills you've learned now serve you." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("7f3d0e34-f227-4d4a-bd89-4ea3ef36c290"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("04a88ae0-aa44-41ec-91af-9ceb61651b97"), StatId = Stats.Instances.Dexterity.ID },
                    new StatEffectBinding{Id = Guid.Parse("2a454d07-cc14-4aa0-b7d3-a518578a756d"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("bc5c1bf7-a4c0-44e3-b172-b2ef8a6e34ca")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("095023f8-2c34-47a5-b6c0-b685d8888730"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Society.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("cb700bf8-a153-44ca-b75b-bbcfa8782bd8"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Labor.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("86b47baa-cd6a-4851-af01-cab2f99f633a"),
                FeatId = Feats.General.ReadLipsFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("42724bd7-a131-49d2-b0d0-0e9aa67ec0d9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 49
            };
        }
    }
}
