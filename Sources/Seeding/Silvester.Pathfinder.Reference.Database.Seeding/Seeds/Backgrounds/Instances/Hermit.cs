using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;


using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Hermit : Template
    {
        public static readonly Guid ID = Guid.Parse("9fbb9f8d-d379-463b-8734-0926eb093cd1");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Hermit",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("536b8e63-6330-4103-a2c8-14d4c774bf61"), Type = TextBlockType.Text, Text = "In an isolated place'like a cave, remote oasis, or secluded mansion'you lived a life of solitude. Adventuring might represent your first foray out among other people in some time. This might be a welcome reprieve from solitude or an unwanted change, but in either case, you're likely still rough around the edges." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("3f74db3b-8820-422d-955f-f59b7390873f"), or => 
            {
                or.GainSpecificAbilityBoost(Guid.Parse("e6524e08-de73-46b0-b3c1-58a0f8a680ed"), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("d47407fb-b2eb-4384-8e2c-8e55340a42e7"), Stats.Instances.Intelligence.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("c89ee42c-0efb-4c9e-998f-ec0d6c05bde3"));

            builder.AddOr(Guid.Parse("f99f8536-0661-4046-bbb9-222a222d0ea5"), or =>
            {
                or.GainSpecificSkillProficiency(Guid.Parse("1776ad6e-59b7-480f-b3d7-3c894b80fe3b"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                or.GainSpecificSkillProficiency(Guid.Parse("578f7a64-e1e0-48da-819b-bd4c5f1fc069"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            });

            builder.GainSpecificLoreCategoryProficiency(Guid.Parse("af37ff14-2bf6-45f8-abfb-768719731548"), Proficiencies.Instances.Trained.ID, LoreCategories.Instances.Terrains.ID, "The chosen Lore skill must be related to the terrain you lived in as a hermit (such as Cave Lore or Desert Lore).");
            builder.GainSpecificFeat(Guid.Parse("7177c695-912c-469b-bc66-2dc1e4c3dcd5"), Feats.Instances.DubiousKnowledge.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("34d2e37f-2ae5-468a-9433-841766891ebb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 62
            };
        }
    }
}
