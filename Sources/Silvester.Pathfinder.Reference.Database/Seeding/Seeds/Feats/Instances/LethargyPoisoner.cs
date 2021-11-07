using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LethargyPoisoner : Template
    {
        public static readonly Guid ID = Guid.Parse("9f05ff9d-c899-44ea-95b6-408eb4eb14cc");

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
            yield return new TextBlock { Id = Guid.Parse("7081dc85-34c0-43f7-894d-e212edd51416"), Type = TextBlockType.Text, Text = "You&#39;ve learned more than the use of hand crossbows from drow lore. During your daily preparations, you can prepare a dose of (item: lethargy poison) from ordinary materials in a wilderness or urban area. If you&#39;re an expert in Crafting, you can instead craft a dose of (item: stupor poison). You can prepare two doses (of either poison) if you&#39;re a master in Crafting and three doses if you&#39;re legendary in Crafting. The save DC for this poison is equal to your class DC." };
            yield return new TextBlock { Id = Guid.Parse("963d77a3-1bc9-4a09-9564-d25a7ad65bf4"), Type = TextBlockType.Text, Text = "Only you can use these poisons, and they expire the next time you make your daily preparations. The GM might decide that the area you&#39;re in is too barren to provide the materials you need for this feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6f186b59-71e7-4fb8-ac80-27f807b947ba"), Feats.Instances.DrowShootistDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("1bd367e0-e537-45e7-94f8-dad6d5d87316"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2e0f8688-cff4-490e-a7c3-693fb118e485"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
