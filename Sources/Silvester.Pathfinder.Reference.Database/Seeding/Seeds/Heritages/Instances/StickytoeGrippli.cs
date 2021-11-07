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
    public class StickytoeGrippli : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Stickytoe Grippli"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your hands and feet exude a film that helps them adhere to surfaces. You gain a +2 circumstance bonus to your Fortitude and Reflex DC against attempts to Disarm, Shove, or Trip you. When ascending trees, vines, and other foliage, if you roll a success on the Athletics check to Climb, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse(""), SavingThrowStats.Instances.Fortitude.ID, SkillActions.Instances.Disarm.ID, bonus: 2);
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse(""), SavingThrowStats.Instances.Fortitude.ID, SkillActions.Instances.Shove.ID, bonus: 2);
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse(""), SavingThrowStats.Instances.Fortitude.ID, SkillActions.Instances.Trip.ID, bonus: 2);
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse(""), SavingThrowStats.Instances.Reflex.ID, SkillActions.Instances.Disarm.ID, bonus: 2);
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse(""), SavingThrowStats.Instances.Reflex.ID, SkillActions.Instances.Shove.ID, bonus: 2);
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse(""), SavingThrowStats.Instances.Reflex.ID, SkillActions.Instances.Trip.ID, bonus: 2);
            builder.ImproveSpecificSkillSpecificSkillActionCheck(Guid.Parse(""), Skills.Instances.Athletics.ID, SkillActions.Instances.Climb.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);

        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 119
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Grippli.ID;
        }
    }
}
