using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InventorDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("4ba7f240-e1f7-4c06-8e4f-85ac244abe83");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Inventor Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have first gained two other feats from the inventor archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4843ec76-df2d-4a6d-8bfc-7eb1bbc9d015"), Type = TextBlockType.Text, Text = "You become trained in Crafting and inventor class DC. You gain the (feat: Inventor) skill feat, even if you don’t meet the skill feat’s requirements. Choose an innovation. You gain that innovation, though you don’t gain any other abilities that modify or use that innovation, such as modifications or (feat: Explode)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("850a5364-7a70-4376-aec4-cfa5602f7b10"), requiredStatValue: 14, Stats.Instances.Intelligence.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a8c44369-bd2e-4ef8-b8fc-f62b49d9f82f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
