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
    public class Bandit : Template
    {
        public static readonly Guid ID = Guid.Parse("42f87045-dbef-47b3-b756-50a00346b924");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Bandit",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("395880ae-850b-4c16-91cb-394ed10bdb7c"), Type = TextBlockType.Text, Text = "Your past includes no small amount of rural banditry, robbing travelers on the road and scraping by. Whether your robbery was sanctioned by a local noble or you did so of your own accord, you eventually got caught up in the adventuring life. Now, adventure is your stock and trade, and years of camping and skirmishing have only helped." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("01241469-f040-4370-a1d1-1b3319702a15"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("e99d5d0d-f83b-4457-8dc9-36dc1cb1fb60"), Stats.Instances.Dexterity.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("21c66bd1-763c-404a-a470-482d0c54ad3d"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("2b948e54-001d-4668-b5ea-e6ceba813592"));
            builder.GainSpecificSkillProficiency(Guid.Parse("4776e60f-bdfe-470f-a1b0-29a3753b3cf9"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
            builder.GainSpecificLoreCategoryProficiency(Guid.Parse("840299f7-9bd4-495c-a7e3-ffa8d466aa3b"), Proficiencies.Instances.Trained.ID, LoreCategories.Instances.Terrains.ID, "The chosen lore skill must be related to a terrain you've worked in (such as Deser Lore or Plains Lore).");
            builder.GainSpecificFeat(Guid.Parse("94555089-3316-4c27-a356-dcef24f4ce9b"), Feats.Instances.GroupCoercion.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a26c282-f8a9-4d89-9771-e437d2001bf9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 48
            };
        }
    }
}
