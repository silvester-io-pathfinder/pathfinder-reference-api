using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class TreedwellerGoblin : Template
    {
        public static readonly Guid ID = Guid.Parse("35e10760-e9f1-4570-89f6-7fd2c3ecee42");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Treedweller Goblin"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7b67660a-aba7-4754-af30-df140a6c4680"), Type = TextBlockType.Text, Text = "You have adapted particularly well to living in forested environments. As long as you are in a forest or jungle, you gain a +2 circumstance bonus to Stealth checks to Hide and Sneak, Survival checks to Subsist, and your Survival DC to Cover Tracks." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillSpecificSkillActionCircumstanceBonus(Guid.Parse("f76b4ac6-7f5d-4f40-ae01-f47aa46cb702"), Skills.Instances.Stealth.ID, SkillActions.Instances.Hide.ID, bonus: 2, addendum: "Only applies if you are in a forest or a jungle.");
            builder.GainSpecificSkillSpecificSkillActionCircumstanceBonus(Guid.Parse("d8ff7be6-3a08-43a5-b9a1-4b198df42325"), Skills.Instances.Stealth.ID, SkillActions.Instances.Sneak.ID, bonus: 2, addendum: "Only applies if you are in a forest or a jungle.");
            builder.GainSpecificSkillSpecificSkillActionCircumstanceBonus(Guid.Parse("314d5de0-b7ed-4b1d-95cf-eb8f707bf757"), Skills.Instances.Survival.ID, SkillActions.Instances.Subsist.ID, bonus: 2, addendum: "Only applies if you are in a forest or a jungle.");
            builder.GainSpecificSkillSpecificSkillActionDcCircumstanceBonus(Guid.Parse("66cabfe6-61fc-4919-a0dc-9ad50ebaa412"), Skills.Instances.Survival.ID, SkillActions.Instances.CoverTracks.ID, bonus: 2, addendum: "Only applies if you are in a forest or a jungle.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("85c996bc-8a56-43b1-833c-85327229772f"),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 37
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Goblin.ID;
        }
    }
}
