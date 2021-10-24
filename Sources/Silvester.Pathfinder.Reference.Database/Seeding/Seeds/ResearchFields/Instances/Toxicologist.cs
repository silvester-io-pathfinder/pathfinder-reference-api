using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ResearchFields.Instances
{
    public class Toxicologist : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ResearchField GetResearchField()
        {
            return new ResearchField
            {
                Id = ID, 
                Name = "Toxicologist", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You specialize in toxins and venoms of all types. You start with the formulas for two common 1st-level alchemical poisons in your formula book, in addition to your other formulas. You can apply an injury poison you're holding to a weapon you're wielding as a single action, rather than as a 2-action activity, and you can change the DCs of your infused poisons to your class DC if it's higher." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyMutagenFormula(Guid.Parse(""), level: 1);
            builder.GainAnyMutagenFormula(Guid.Parse(""), level: 1);
            //TODO: Add injury poison effect.
            //TODO: Add change DC effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 106
            };
        }
    }
}
