using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Methodologies.Instances
{
    public class AlchemicalSciences : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Methodology GetMethodology()
        {
            return new Methodology
            {
                Id = ID, 
                Name = "Alchemical Sciences",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your methodology emphasizes chemical and alchemical analysis, collecting information from unusual particles and fluids found on the scene. You possess enough alchemical know-how to whip up a few tinctures to help you with your cases." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You’re trained in Crafting and gain the Alchemical Crafting skill feat (Core Rulebook 258). In addition, you gain a standard formula book for free and learn the formulas for two additional common 1st-level alchemical items, which must be elixirs or tools. Each time you gain a level, you learn the formula for one common alchemical elixir or alchemical tool of any level of item you can create." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "During your daily preparations, you can create a number of versatile vials—alchemical concoctions that can quickly be turned into elixirs and tools— equal to your Intelligence modifier. You can use the Quick Tincture action to turn one of these vials into an elixir or alchemical tool for which you know the formula." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse(""),
                SkillId = Skills.Instances.Crafting.ID,
                ProficiencyId = Proficiencies.Instances.Trained.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse(""),
                FeatId = Feats.Instances.AlchemicalCrafting.ID
            };

            //TODO: This needs more restrictions somehow.
            yield return new GainFormulaBookEffect
            {
                Id = Guid.Parse(""),
                FormulaAmount = 2,
                AddFormulasPerLevel = 2
            };

            //TODO: Add daily preparation effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 57
            };
        }
    }
}
