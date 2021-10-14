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
    public class Pilgrim : Template
    {
        public static readonly Guid ID = Guid.Parse("ad0767b8-8588-4e00-ba5e-8335b48fea81");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Pilgrim",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("608b5903-feea-41f3-bd1c-6c0625715745"), Type = TextBlockType.Text, Text = "In your youth, you made several pilgrimages to important shrines and holy sites. You might have been a mendicant friar, a seller of holy relics (real or fraudulent), or just a simple farmer following the dictates of your faith. Whatever the aims of your wanderings now, your faith still protects you on the road." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("fa5f7787-6e89-402a-aaed-e001d7ff75df"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("02a0f51b-9d4a-45ef-ae4a-b9295310beab"), StatId = Stats.Instances.Wisdom.ID },
                    new StatEffectBinding{Id = Guid.Parse("1c28a28a-42b4-4614-a7b4-cdb9625349c0"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("36f202d6-b8b4-407e-9a02-bde493d5fd42")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("ad6f0ed4-be4f-45d9-9d3a-d42373fea86e"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Nature.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("a77a675a-6d71-47f8-b67c-8953b388543a"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Plant.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("e2a83883-771a-46a1-81ee-e872b2ffe8f6"),
                FeatId = Feats.General.NaturalMedicineFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eb3dc989-c572-4d96-917f-d8c8ec51d8a1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 49
            };
        }
    }
}
