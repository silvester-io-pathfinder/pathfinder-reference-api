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
    public class LongsnoutRat : Template
    {
        public static readonly Guid ID = Guid.Parse("b0a003ee-cb17-47cb-866b-f6e65b78dbd4");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Longsnout Rat"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b4eae4fd-2615-4f8e-b727-10e373fe569c"), Type = TextBlockType.Text, Text = "The long snouts that run in your family give you a keener sense of smell than most ratfolk. You gain imprecise scent with a range of 30 feet. This means you can use your sense of smell to determine a creature's location. The GM will usually double the range if you're downwind from the creature or halve the range if you're upwind." };
            yield return new TextBlock { Id = Guid.Parse("0837fadb-447d-4ad3-80c0-20db53598c44"), Type = TextBlockType.Text, Text = "In addition, you gain a +2 circumstance bonus to Perception checks to Seek a creature or object within the range of your scent." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSense(Guid.Parse("7c32ddec-97e8-4b5d-9809-53ea77aa58c1"), Senses.Instances.Scent.ID, SenseAccuracies.Instances.Imprecise.ID, "30 feet.");
            builder.GainSpecificSkillSpecificActionCircumstanceBonus(Guid.Parse("a2c1c0e0-5249-4226-ae83-c4584c624176"), Skills.Instances.Perception.ID, Actions.Instances.Seek.ID, bonus: 2, addendum: "Within the range of your scent (30 feet by default).");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9527985c-3959-4609-9781-96898a6b0abc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 21
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Ratfolk.ID;
        }
    }
}
