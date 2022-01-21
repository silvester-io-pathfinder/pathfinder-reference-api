using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Barber : Template
    {
        public static readonly Guid ID = Guid.Parse("61e6910c-3bfc-4083-bc7a-1334661c1fca");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Barber",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("58eb06b3-8656-43a3-ac7a-c28d30b6734a"), Type = TextBlockType.Text, Text = "Haircuts, dentistry, bloodletting, and surgery'if it takes a steady hand and a razor, you do it. You may have taken to the road to expand your skills, or to test yourself against a world that leaves your patients so battered and bruised." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("171d5bff-13b2-41a6-8f20-095017121d62"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("460f0dd2-8f50-4d08-a289-3f4c771305a9"), Stats.Instances.Dexterity.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("a46bcfa1-8bfe-4291-8fb6-20581f42d2e9"), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("959a1bb4-1e30-4760-86fb-de517b860464"));
            builder.GainSpecificSkillProficiency(Guid.Parse("9dcc7e9c-27ea-421a-8910-65e0f6bca06d"), Proficiencies.Instances.Trained.ID, Skills.Instances.Medicine.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("35d154ee-dd01-438f-8113-15f789d25323"), Proficiencies.Instances.Trained.ID, Lores.Instances.Surgery.ID);
            builder.GainSpecificFeat(Guid.Parse("42e0b035-f927-4924-9ead-daf794ae907d"), Feats.Instances.RiskySurgery.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f1983c92-0c2e-411a-94f1-3fb75a383757"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 48
            };
        }
    }
}
