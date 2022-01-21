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
    public class Gladiator : Template
    {
        public static readonly Guid ID = Guid.Parse("9210f894-a46d-47df-a118-e0d2eb2fb030");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Gladiator",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("521dd03c-9677-4876-ba0c-f1d2c288012f"), Type = TextBlockType.Text, Text = "The bloody games of the arena taught you the art of combat. Before you attained true fame, you departed'or escaped'the arena to explore the world. Your skill at drawing both blood and a crowd's attention pay off in a new adventuring life." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("d584c18d-46dc-45ad-80bc-cd9097a69aae"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("8f154521-5022-4db4-9597-11e4ed354576"), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("59624fa8-3cae-4931-90da-774b35b97f50"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("b0f243e9-10b0-494c-8915-06ff2748de58"));
            builder.GainSpecificSkillProficiency(Guid.Parse("0cb60fa8-a251-4cd6-b3c0-30b1b4266ffd"), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("ae041b8d-cb77-4626-a559-e461f7d78d95"), Proficiencies.Instances.Trained.ID, Lores.Instances.Gladiatorial.ID);
            builder.GainSpecificFeat(Guid.Parse("6d1648e7-0837-4bda-bb99-f277e560b8d4"), Feats.Instances.ImpressivePerformance.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6fef9205-aa5f-4241-9c74-6f018825fc25"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 62
            };
        }
    }
}
