using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Alchemists
{
    public class FormulaBook : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Name = "Formula Book", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "An alchemist keeps meticulous records of the formulas for every item they can create. You start with a standard formula book worth 10 sp or less for free. The formula book contains the formulas for two common 1st-level alchemical items of your choice, in addition to those you gained from Alchemical Crafting and your research field. Alchemical Items can be found here." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Each time you gain a level, you can add the formulas for two common alchemical items to your formula book. These new formulas can be for any level of item you can create. You learn these formulas automatically, but it's also possible to find or buy additional formulas in settlements or from other alchemists, or to invent them with the Inventor feat." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainFormulaBookEffect
            {
                Id = Guid.Parse(""),
                FormulaAmount = 2,
                AddFormulasPerLevel = 2
            };

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
