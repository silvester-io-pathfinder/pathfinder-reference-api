using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class RaisedByBelief : Template
    {
        public static readonly Guid ID = Guid.Parse("671153d8-264f-4be2-87df-c1993cbf1a96");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Raised by Belief",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ba1b2d41-e796-4c9c-8a95-5cbe8a1802cc"), Type = TextBlockType.Text, Text = "Whether in a monastery, a religious household, or just as part of your everyday life, your upbringing was steeped in the traditions of a faith or philosophy. You might remain committed or you may have turned from your childhood creed, but your skills are still founded in your devotion." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAbilityBoost(Guid.Parse(""), restrictions: "The chosen ability must be listed in the Divine Ability entry for your deity.");
            builder.GainAnyAbilityBoost(Guid.Parse(""));


            builder.GainAnySkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, "The chosen skill must be your deity's associated skill.");
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.Assurance.ID, "The Assurance skill feat should relate to your deity's associated skill.");
            builder.GainSpecificLoreCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, LoreCategories.Instances.Deities.ID, "The chosen Lore skill must be associated with your deity (Abadar Lore, for instance).");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7f491382-4ec8-4d07-b0e6-d7c61cf0a932"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 9
            };
        }
    }
}
