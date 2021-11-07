using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PrescientConsumable : Template
    {
        public static readonly Guid ID = Guid.Parse("0bdf2b03-6e7c-4374-a2a4-78b0690b5298");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Prescient Consumable",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("911b723a-31a6-4d42-a1a0-2fe3852245ad"), Type = TextBlockType.Text, Text = "You can predict which consumables you might need in advance. When using (feat: Prescient Planner), you can procure a consumable item from your backpack, instead of a piece of adventuring gear. The consumable item must still be common with a level no higher than half your level, and its Bulk must be low enough that carrying it wouldn’t have made you encumbered." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cec849f5-5dd6-4f7c-8581-226f7003a899"), Feats.Instances.PrescientPlanner.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a0b19629-ad37-44b2-9a43-3d5de2a20397"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
