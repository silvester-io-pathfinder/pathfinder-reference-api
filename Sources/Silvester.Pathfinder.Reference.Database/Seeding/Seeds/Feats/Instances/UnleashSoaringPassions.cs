using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnleashSoaringPassions : Template
    {
        public static readonly Guid ID = Guid.Parse("7286a49f-91ea-4418-9e93-f4c9e2184460");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unleash Soaring Passions",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ac30ff2a-3795-4ff4-98d6-0f9684f72380"), Type = TextBlockType.Text, Text = "Your power crests with each victory and ebbs with each setback." };
            yield return new TextBlock { Id = Guid.Parse("e00a62cc-97a6-417e-90a7-6e4da389cb6d"), Type = TextBlockType.Text, Text = "~ Benefit: While this psyche is unleashed, if you succeed at a spell attack roll, you gain a +2 status bonus to your next spell attack roll, and if an enemy fails its save against your spell, it takes a –2 status penalty to the next save they attempt against one of your spells. This bonus or penalty lasts until the end of your next turn." };
            yield return new TextBlock { Id = Guid.Parse("c43ac062-d2fe-460c-9269-f9f9a7fde03a"), Type = TextBlockType.Text, Text = "~ Drawback: While this psyche is Unleashed, when you fail at a spell attack roll, you take a –1 penalty to your next spell attack roll; if an enemy succeeds at its save against your spell, they gain a +1 status bonus to the next save they attempt against one of your spells. This penalty or bonus lasts until the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a97bdf3e-518c-4ab0-81ef-71256adb3a89"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
