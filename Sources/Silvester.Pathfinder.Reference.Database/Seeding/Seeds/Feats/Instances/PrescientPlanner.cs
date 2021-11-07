using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PrescientPlanner : Template
    {
        public static readonly Guid ID = Guid.Parse("92d0e6fa-ebaa-4ea6-9608-fc6e1f4d37a7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Prescient Planner",
                Level = 3,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a18b99ae-b244-4064-959e-d45e7854dfce"), Type = TextBlockType.Text, Text = "You regularly create convoluted plans and contingencies, using your resources to enact them. You take 1 minute to remove your backpack, then carefully remove an item you hadn’t previously declared that you purchased – you intuited that you would come to need the item and purchased it at the latest opportunity. The item must be a piece of adventuring gear, and can’t be a weapon, armor, alchemical item, magic item, or other treasure. It must be common with a level no higher than half your level, and its Bulk must be low enough that carrying it wouldn’t have made you encumbered." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad0e33aa-7b6e-494d-99e0-391139e509d8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
