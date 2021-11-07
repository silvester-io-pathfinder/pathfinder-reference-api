using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TwinParry : Template
    {
        public static readonly Guid ID = Guid.Parse("ae55aa53-fe0b-4ada-82b0-c366e463ef2a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Twin Parry",
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
            yield return new TextBlock { Id = Guid.Parse("561ec790-e8ac-42ec-8d96-c4145efd2023"), Type = TextBlockType.Text, Text = "You use your two weapons to parry attacks. You gain a +1 circumstance bonus to AC until the start of your next turn, or a +2 circumstance bonus if either weapon has the (trait: parry) trait. You lose this circumstance bonus if you no longer meet this feat’s requirement." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("40a0785e-54df-49a2-bc73-011908d3891e"), Feats.Instances.DualWeaponWarriorDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c3bd1809-59fb-44eb-9489-e1032196de35"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
