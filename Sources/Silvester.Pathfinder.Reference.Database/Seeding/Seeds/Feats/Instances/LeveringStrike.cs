using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LeveringStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("43505870-345a-4734-9402-c8efeec998e9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Levering Strike",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b0a9c076-450c-4d5e-a13f-20c76cbb4269"), Type = TextBlockType.Text, Text = "Make a (action: Strike) with your staff. As long as you don’t critically fail, the target becomes flat-footed and takes a -2 circumstance penalty to its DC against (action: Shove), (action: Trip), and (action: Tumble Through) attempts until the start of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d56fd1f7-b8f4-4c07-8569-271890017dc9"), Feats.Instances.StaffAcrobatDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2bbce1a-5ff4-47a3-8914-1ea25da1e2c2"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
