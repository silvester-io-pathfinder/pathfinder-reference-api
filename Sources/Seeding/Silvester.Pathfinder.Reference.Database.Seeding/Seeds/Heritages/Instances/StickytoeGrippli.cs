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
        public static readonly Guid ID = Guid.Parse("61716fa1-13a7-4a1a-a86a-5d8ca5fe72fd");

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
            yield return new TextBlock { Id = Guid.Parse("5ffcfa7b-b37f-4342-a2f7-880c46ceeb92"), Type = TextBlockType.Text, Text = "Your hands and feet exude a film that helps them adhere to surfaces. You gain a +2 circumstance bonus to your Fortitude and Reflex DC against attempts to Disarm, Shove, or Trip you. When ascending trees, vines, and other foliage, if you roll a success on the Athletics check to Climb, you get a critical success instead." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse("bb0fd6b0-56c0-404d-9017-1e5fda829763"), SavingThrowStats.Instances.Fortitude.ID, SkillActions.Instances.Disarm.ID, bonus: 2);
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse("d99ec4dd-0e5b-4fe3-926e-e97e9231fd73"), SavingThrowStats.Instances.Fortitude.ID, SkillActions.Instances.Shove.ID, bonus: 2);
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse("86bf68c9-b648-4de8-976b-d8524b32a6b8"), SavingThrowStats.Instances.Fortitude.ID, SkillActions.Instances.Trip.ID, bonus: 2);
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse("3f5769b7-aaa1-40cb-bcb6-cca72dea10e8"), SavingThrowStats.Instances.Reflex.ID, SkillActions.Instances.Disarm.ID, bonus: 2);
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse("a8685cbc-a54f-451f-bb2e-b96f3b4b7970"), SavingThrowStats.Instances.Reflex.ID, SkillActions.Instances.Shove.ID, bonus: 2);
            builder.GainSpecificSkillActionSpecificSavingThrowCircumstanceBonus(Guid.Parse("3c26fbf5-3cb3-4e6e-895d-82b20a90b98b"), SavingThrowStats.Instances.Reflex.ID, SkillActions.Instances.Trip.ID, bonus: 2);
            builder.ImproveSpecificSkillSpecificSkillActionCheck(Guid.Parse("518e794b-8372-4452-9cdd-6a0692507993"), Skills.Instances.Athletics.ID, SkillActions.Instances.Climb.ID, RollResult.Success, becomes: RollResult.CriticalSuccess);

        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("929749cb-c027-42dd-86fb-55d63d1da345"),
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
