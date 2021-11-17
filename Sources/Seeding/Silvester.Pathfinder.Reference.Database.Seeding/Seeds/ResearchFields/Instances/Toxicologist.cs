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
        public static readonly Guid ID = Guid.Parse("00d38afc-8f1d-4503-8bff-56dd14ac7473");

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
            yield return new TextBlock { Id = Guid.Parse("e9c7fce8-52ca-4397-b70a-7a9532025815"), Type = TextBlockType.Text, Text = "You specialize in toxins and venoms of all types. You start with the formulas for two common 1st-level alchemical poisons in your formula book, in addition to your other formulas. You can apply an injury poison you're holding to a weapon you're wielding as a single action, rather than as a 2-action activity, and you can change the DCs of your infused poisons to your class DC if it's higher." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyMutagenFormula(Guid.Parse("dfed02b8-3bb0-4084-957d-488ade6b1f86"), level: 1);
            builder.GainAnyMutagenFormula(Guid.Parse("da713297-4341-4474-8e61-56c175e2738a"), level: 1);
            //TODO: Add injury poison effect.
            //TODO: Add change DC effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f41dfafc-423b-477c-aec1-1d0f0786e30e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 106
            };
        }
    }
}
