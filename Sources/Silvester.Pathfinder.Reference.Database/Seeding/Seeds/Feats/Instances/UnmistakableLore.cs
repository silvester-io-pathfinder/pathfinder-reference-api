using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnmistakableLore : Template
    {
        public static readonly Guid ID = Guid.Parse("ceb9acd1-b634-44a2-b021-7b4ffa1080b8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unmistakable Lore",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f3e3f791-6dc5-40e6-8bb6-227046f6359e"), Type = TextBlockType.Text, Text = "You never get information about your areas of expertise wrong." };
            yield return new TextBlock { Id = Guid.Parse("41547954-9ec9-480f-af7e-33c9be65c8f2"), Type = TextBlockType.Text, Text = "When you (action: Recall Knowledge) using any Lore subcategory in which you’re trained, if you roll a critical failure, you get a failure instead. If you’re a master in a Lore subcategory, on a critical success, you gain even more information or context than usual." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyLoreProficiency(Guid.Parse("65220b9d-8ca5-4edf-96f4-de1f7b1099b5"), Proficiencies.Instances.Expert.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b4832524-bc1e-4f2e-89fe-bcb27a61c796"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
