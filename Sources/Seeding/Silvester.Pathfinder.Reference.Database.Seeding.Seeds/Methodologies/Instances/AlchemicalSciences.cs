using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Methodologies.Instances
{
    public class AlchemicalSciences : Template
    {
        public static readonly Guid ID = Guid.Parse("25757fb3-7aad-49d5-9f4b-81d8294dc117");
        
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
            yield return new TextBlock { Id = Guid.Parse("36cc3bdb-9265-45ab-b01f-3d800ee07215"), Type = TextBlockType.Text, Text = "Your methodology emphasizes chemical and alchemical analysis, collecting information from unusual particles and fluids found on the scene. You possess enough alchemical know-how to whip up a few tinctures to help you with your cases." };
            yield return new TextBlock { Id = Guid.Parse("66775e84-141c-4858-8d03-1995dc73ce4a"), Type = TextBlockType.Text, Text = "you're trained in Crafting and gain the Alchemical Crafting skill feat (Core Rulebook 258). In addition, you gain a standard formula book for free and learn the formulas for two additional common 1st-level alchemical items, which must be elixirs or tools. Each time you gain a level, you learn the formula for one common alchemical elixir or alchemical tool of any level of item you can create." };
            yield return new TextBlock { Id = Guid.Parse("6c3d87be-2084-48d3-8bc3-5a36df8d1a3b"), Type = TextBlockType.Text, Text = "During your daily preparations, you can create a number of versatile vials - alchemical concoctions that can quickly be turned into elixirs and tools - equal to your Intelligence modifier. You can use the Quick Tincture action to turn one of these vials into an elixir or alchemical tool for which you know the formula." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("c52631f9-96ae-4be9-b49d-f34dc3c9449d"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
            builder.GainSpecificFeat(Guid.Parse("5a420ce6-4cbe-4838-9f5d-b663454e2f8a"), Feats.Instances.AlchemicalCrafting.ID);
            //TODO: This needs more restrictions somehow.
            builder.GainFormulaBook(Guid.Parse("622fdb8f-6aee-4180-ac62-55fcd14195b9"), formulaAmount: 2, addFormulasPerLevel: 2);
            //TODO: Add daily preparation effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d919b45d-b80c-40fc-975f-d2784c3cd42f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 57
            };
        }
    }
}
