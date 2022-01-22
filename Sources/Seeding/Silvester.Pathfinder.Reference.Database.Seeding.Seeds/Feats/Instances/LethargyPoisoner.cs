using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LethargyPoisoner : Template
    {
        public static readonly Guid ID = Guid.Parse("36700969-f696-4833-9245-86963af24f88");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lethargy Poisoner",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e859bcdd-5dea-4b85-a8ae-fae99cfe97f0"), Type = TextBlockType.Text, Text = $"You've learned more than the use of hand crossbows from drow lore. During your daily preparations, you can prepare a dose of {ToMarkdownLink<Models.Items.Instances.AlchemicalPoison>("lethargy poison", Items.AlchemicalPoisons.Instances.LethargyPoison.ID)} from ordinary materials in a wilderness or urban area. If you're an expert in Crafting, you can instead craft a dose of {ToMarkdownLink<Models.Items.Instances.AlchemicalPoison>("stupor poison", Items.AlchemicalPoisons.Instances.StuporPoison.ID)}. You can prepare two doses (of either poison) if you're a master in Crafting and three doses if you're legendary in Crafting. The save DC for this poison is equal to your class DC." };
            yield return new TextBlock { Id = Guid.Parse("6ee74e77-7045-4411-91bd-a4f1312cbd96"), Type = TextBlockType.Text, Text = $"Only you can use these poisons, and they expire the next time you make your daily preparations. The GM might decide that the area you're in is too barren to provide the materials you need for this feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f1349fb6-fe78-4fc8-b379-61f50b0314c2"), Feats.Instances.DrowShootistDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("b1a663b8-ff2e-43f1-99cb-3c37104c7503"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d6b72963-b032-47f2-81c3-4fbbab795c69"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
