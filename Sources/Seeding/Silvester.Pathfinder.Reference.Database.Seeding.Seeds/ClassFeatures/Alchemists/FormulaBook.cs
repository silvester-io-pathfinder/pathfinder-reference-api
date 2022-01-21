using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Alchemists
{
    public class FormulaBook : Template
    {
        public static readonly Guid ID = Guid.Parse("44f177ca-4a30-49df-9173-53ec4870d2e6");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Formula Book", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("cb5259f7-5bbb-4239-b59f-831f6fc77451"), Type = TextBlockType.Text, Text = "An alchemist keeps meticulous records of the formulas for every item they can create. You start with a standard formula book worth 10 sp or less for free. The formula book contains the formulas for two common 1st-level alchemical items of your choice, in addition to those you gained from Alchemical Crafting and your research field. Alchemical Items can be found here." };
            yield return new TextBlock { Id = Guid.Parse("90a4b686-772d-4362-b3d6-6a43f033a3be"), Type = TextBlockType.Text, Text = "Each time you gain a level, you can add the formulas for two common alchemical items to your formula book. These new formulas can be for any level of item you can create. You learn these formulas automatically, but it's also possible to find or buy additional formulas in settlements or from other alchemists, or to invent them with the Inventor feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainFormulaBook(Guid.Parse("8c7e6ead-c13b-47c3-8f06-7f110b029aa8"), formulaAmount: 2, addFormulasPerLevel: 2);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("167300ce-3095-4391-8404-af036b73b1bd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 73
            };
        }
    }
}
