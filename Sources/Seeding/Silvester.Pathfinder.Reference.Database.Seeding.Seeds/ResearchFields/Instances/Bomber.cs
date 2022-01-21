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
    public class Bomber : Template
    {
        public static readonly Guid ID = Guid.Parse("1e365429-b417-4988-8e84-3bff3212c5b6");

        protected override ResearchField GetResearchField()
        {
            return new ResearchField
            {
                Id = ID, 
                Name = "Bomber", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7c5007a2-767c-44ed-bf6e-a835147390e8"), Type = TextBlockType.Text, Text = "You specialize in explosions and other violent alchemical reactions. You start with the formulas for two 1st-level alchemical bombs in your formula book, in addition to your other formulas." };
            yield return new TextBlock { Id = Guid.Parse("e7b13578-a715-4db8-854d-f62521e7c0fc"), Type = TextBlockType.Text, Text = "When throwing an alchemical bomb with the splash trait, you can deal splash damage to only your primary target instead of the usual splash area." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyAlchemicalBombFormula(Guid.Parse("24a940cb-60dd-4258-893c-14795ce08b73"), level: 1);
            builder.GainAnyAlchemicalBombFormula(Guid.Parse("1ea7d7cf-e91d-43ab-8ed3-9c68e1c123ef"), level: 1);
            //TODO: Add splash trait modification effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("103ddad6-4a45-4b78-9fa7-0037aa5d5dde"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 73
            };
        }
    }
}
