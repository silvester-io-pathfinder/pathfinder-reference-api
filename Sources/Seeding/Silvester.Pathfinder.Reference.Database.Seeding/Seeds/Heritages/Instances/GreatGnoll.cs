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
    public class GreatGnoll : Template
    {
        public static readonly Guid ID = Guid.Parse("4eb37a03-5688-4f64-b447-0412e16d84af");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Great Gnoll"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c333b568-455f-42cd-965f-619b920990f4"), Type = TextBlockType.Text, Text = "You're a large, powerful gnoll, with tawny fur and brown spots on your hide. You gain 10 Hit Points from your ancestry instead of 8 and gain a +1 circumstance bonus to Athletics checks to Shove or Trip foes." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyAncestryHitpoints(Guid.Parse("aaa9fbdc-0abe-4282-b2c7-527005997515"), ModifierType.Add, modifier: 2);
            builder.GainSpecificSkillSpecificSkillActionCircumstanceBonus(Guid.Parse("32e11cbe-3422-419d-918a-73683071bb4f"), Skills.Instances.Athletics.ID, SkillActions.Instances.Shove.ID, bonus: 1);
            builder.GainSpecificSkillSpecificSkillActionCircumstanceBonus(Guid.Parse("dbd896df-5124-4699-a298-4ddae5ce8357"), Skills.Instances.Athletics.ID, SkillActions.Instances.Trip.ID, bonus: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8aeee823-d9b4-46d7-8aeb-6d9140811c46"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 111
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Gnoll.ID;
        }
    }
}
