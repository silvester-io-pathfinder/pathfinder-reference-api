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
            builder.AddOr(Guid.Parse("2f32ad00-1014-48b9-b1b1-b04e4bbc4d69"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("d0699cde-53e1-445e-a412-5d8f2f0cc220"), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("16b11180-efef-4e7f-bd58-36917f843d27"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("968c7288-4753-4c1e-8e01-97db3645b11f"));
            builder.AddOr(Guid.Parse("f63caf3f-f4d1-4451-b798-acfb9981499f"), or => 
            {
                or.GainSpecificSkillProficiency(Guid.Parse("ff32b88f-ca63-4c6f-90fb-a83775569ca1"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                or.GainSpecificSkillProficiency(Guid.Parse("b7ebfa80-c8cc-4a22-982c-62552269ab38"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                or.GainSpecificSkillProficiency(Guid.Parse("d4ba5406-0e4c-4c2b-8eee-02313bbd8d4f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                or.GainSpecificSkillProficiency(Guid.Parse("5e541bdf-b20e-4c68-a836-090b85ca8f06"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            });

            builder.GainSpecificLoreProficiency(Guid.Parse("19adc800-0201-463d-a6a2-21208ccebcb6"), Proficiencies.Instances.Trained.ID, Lores.Instances.Academia.ID);
            builder.GainSpecificLoreCategoryProficiency(Guid.Parse("7ad2a1d8-68cb-4358-b371-21968c85184e"), Proficiencies.Instances.Trained.ID, LoreCategories.Instances.Creatures.ID, "The chosen Lore skill must be associated with your contacted eidolon (such as Angel Lore or Dragon Lore).");
            builder.GainSpecificFeat(Guid.Parse("82db4021-ffdf-4832-b154-8ace52ad9f25"), Feats.Instances.DubiousKnowledge.ID);
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
