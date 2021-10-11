using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("58531d3f-282d-47c6-8bb6-e3cac93c080e"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("a13b6522-b21e-475e-b139-454df3834830"), StatId = Stats.Instances.Constitution.ID },
                    new StatEffectBinding{Id = Guid.Parse("4160e4ff-8905-4347-9b98-657fa07c4be9"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("4ced98cf-1359-4c92-acf5-9c1b5e626d73")
            };

            yield return new ChoiceEffect
            {
                Id = Guid.Parse("9ee2d51a-e6bf-4cef-b217-01117961a911"),
                Choices = new Effect[]
                {
                    new RestrictedSkillEffect {Id = Guid.Parse("72d33829-d5c0-465d-97a3-99636ce58724"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Arcana.ID},
                    new RestrictedSkillEffect {Id = Guid.Parse("b8d9a4b2-d555-43e5-92ed-b683bdd6908b"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Nature.ID},
                    new RestrictedSkillEffect {Id = Guid.Parse("33291867-122e-4f22-9e76-c8dd60755a93"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Occultism.ID},
                    new RestrictedSkillEffect {Id = Guid.Parse("9acc156b-8d57-46c5-87da-d8b93b635e72"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Religion.ID},
                }
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("73a0002b-9b5e-476e-83cb-31a1e2f7a961"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Academia.ID
            };

            yield return new LoreCategoryEffect
            {
                Id = Guid.Parse("e2c995f7-2a70-4e13-893e-4118b19d47b2"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreCategoryId = LoreCategories.Instances.Creatures.ID,
                Restrictions = "The chosen Lore skill must be associated with your contacted eidolon (such as Angel Lore or Dragon Lore)."
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("d5b1afad-8910-448a-9390-39ce099e60d0"),
                FeatId = Feats.General.DubiousKnowledgeFeat.ID
            };
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
