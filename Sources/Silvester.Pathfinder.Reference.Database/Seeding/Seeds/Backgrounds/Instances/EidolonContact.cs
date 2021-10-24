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
    public class EidolonContact : Template
    {
        public static readonly Guid ID = Guid.Parse("f6638c3f-3b3b-4740-b2f3-8f1d45cac4a2");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Eidolon Contact",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f43d669f-92d4-426d-a7de-e57cb6a4fa4e"), Type = TextBlockType.Text, Text = "You've come into contact with a disembodied being of magical essence known as an eidolon. You might have forged a powerful conduit with that eidolon, allowing you to manifest it as a summoner, but it's much more likely that you lost contact over time, though not before learning a few half-remembered secrets. If you lost contact, you might have become an adventurer to try to reach the eidolon again, or to be sure that you're rid of it forever." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.AddOr(Guid.Parse(""), or => 
            {
                or.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                or.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                or.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                or.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            });

            builder.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Academia.ID);
            builder.GainSpecificLoreCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, LoreCategories.Instances.Creatures.ID, "The chosen Lore skill must be associated with your contacted eidolon (such as Angel Lore or Dragon Lore).");
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.DubiousKnowledge.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("96aadad1-0514-40d3-81d0-f2ae84c22450"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 28
            };
        }
    }
}
