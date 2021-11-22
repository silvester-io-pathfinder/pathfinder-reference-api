using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PrescientPlanner : Template
    {
        public static readonly Guid ID = Guid.Parse("3f0765dd-8363-4326-a87f-b3a82d5b5b73");

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
            yield return new TextBlock { Id = Guid.Parse("1378e04e-35c9-4666-85c0-3fc2c047f748"), Type = TextBlockType.Text, Text = "You regularly create convoluted plans and contingencies, using your resources to enact them. You take 1 minute to remove your backpack, then carefully remove an item you hadn't previously declared that you purchased – you intuited that you would come to need the item and purchased it at the latest opportunity. The item must be a piece of adventuring gear, and can't be a weapon, armor, alchemical item, magic item, or other treasure. It must be common with a level no higher than half your level, and its Bulk must be low enough that carrying it wouldn't have made you encumbered." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b8fe2955-f6b7-4064-ac8e-d211aac8425b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
