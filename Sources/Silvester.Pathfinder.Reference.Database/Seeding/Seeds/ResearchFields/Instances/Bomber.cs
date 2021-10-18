using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ResearchFields.Instances
{
    public class Bomber : Template
    {
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You specialize in explosions and other violent alchemical reactions. You start with the formulas for two 1st-level alchemical bombs in your formula book, in addition to your other formulas." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When throwing an alchemical bomb with the splash trait, you can deal splash damage to only your primary target instead of the usual splash area." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainAnyAlchemicalBombFormulaEffect
            {
                Id = Guid.Parse(""),
                Level = 1
            }; 
            
            yield return new GainAnyAlchemicalBombFormulaEffect
            {
                Id = Guid.Parse(""),
                Level = 1
            };

            //TODO: Add splash trait modification effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 73
            };
        }
    }
}
