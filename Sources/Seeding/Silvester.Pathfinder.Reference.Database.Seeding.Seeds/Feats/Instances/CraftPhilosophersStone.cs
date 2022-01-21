using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CraftPhilosophersStone : Template
    {
        public static readonly Guid ID = Guid.Parse("2988b8f5-fa6b-496e-a63b-ac7c4f035753");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Craft Philosopher's Stone",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("753e15bc-a2f2-4c67-9e22-942ecd1fa55c"), Type = TextBlockType.Text, Text = $"Your research has paid off, culminating in the legendary philosopher's stone. You learn the formula for the {ToMarkdownLink<Models.Items.Instances.AlchemicalTool>("philosopher's stone", Items.AlchemicalTools.Instances.PhilosophersStone.ID)} and can add it to your formula book." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("400dd338-9c48-4194-add2-239948577049"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
