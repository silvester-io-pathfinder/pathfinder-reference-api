using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("704494b4-aa5d-4c15-9406-39801ca64f00"),
                Restrictions = "The chosen ability must be listed in the Divine Ability entry for your deity."
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("810f5daf-86f8-4e1a-80e7-a397cb5a090c")
            };

            yield return new CombinedEffect
            {
                Id = Guid.Parse("cc625d22-aeaa-4334-9fcc-935d2ea79d44"),
                Entries = new Effect[]
                {
                    new FreeSkillEffect { Id = Guid.Parse("3230757c-67bd-4faa-b434-cbde7c7360db"), ProficiencyId = Proficiencies.Instances.Trained.ID, Restrictions = "The chosen skill must be your deity's associated skill."},
                    new FeatEffect { Id = Guid.Parse("f29c4b71-3631-4391-942c-64d8e9a70937"), FeatId = Feats.General.AssuranceFeat.ID, Restrictions = "The Assurance skill feat should relate to your deity's associated skill."}
                }
            };

            yield return new LoreCategoryEffect
            {
                Id = Guid.Parse("fb0accfe-d198-4cce-af67-d83b22142765"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreCategoryId = LoreCategories.Instances.Deities.ID,
                Restrictions = "The chosen Lore skill must be associated with your deity (Abadar Lore, for instance)."
            };
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
