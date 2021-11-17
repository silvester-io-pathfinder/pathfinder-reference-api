using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class InsightfulGoloma : Template
    {
        public static readonly Guid ID = Guid.Parse("700be785-d0dc-48cf-9dfa-a011886b0a69");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Insightful Goloma"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("289c78df-ac37-488c-85e1-513567436c15"), Type = TextBlockType.Text, Text = "You've learned to watch for telltale signs of dangerous sentiments to help you avoid trouble. You gain a +1 circumstance bonus to your Perception DC against attempts to Lie to you and your Perception checks to Sense Motive." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillSpecificSkillActionDcCircumstanceBonus(Guid.Parse("254c31e4-beab-4915-a3c3-f02e53ae488f"), Skills.Instances.Perception.ID, SkillActions.Instances.Lie.ID, bonus: 1);
            builder.GainSpecificSkillSpecificActionCircumstanceBonus(Guid.Parse("98f0bb2e-5ae1-4966-8f0e-1d9f869a1340"), Skills.Instances.Perception.ID, Actions.Instances.SenseMotive.ID, bonus: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("126ae866-4edd-49ac-a43f-a30b5bcbefbe"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 115
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Goloma.ID;
        }
    }
}
