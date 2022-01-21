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
    public class ScavengerStrix : Template
    {
        public static readonly Guid ID = Guid.Parse("707b68a0-c1ca-424f-8e26-67485e1c830e");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Scavenger Strix"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("506d8c13-fa54-40bb-a2b7-62041fc757f4"), Type = TextBlockType.Text, Text = "Your ancestors originated from a land where food was scarce and threats were many. You are trained in Survival. You gain the Forager skill feat as a bonus feat. Your thoroughness when gathering food provides you a +1 circumstance bonus to Survival checks to Subsist." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("55588d55-c180-4451-8426-1eb3a0ee0e54"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
            builder.GainSpecificFeat(Guid.Parse("58211c4a-5c2c-46f0-9c2f-8ceb109288e6"), Feats.Instances.Forager.ID);
            builder.GainSpecificSkillSpecificSkillActionCircumstanceBonus(Guid.Parse("064e8674-e817-4607-9b9a-b3ed82fc40ec"), Skills.Instances.Survival.ID, SkillActions.Instances.Subsist.ID, bonus: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9bd24a54-410f-4819-9d2c-ff52c3abfd87"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 135
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Strix.ID;
        }
    }
}
