using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AxeClimber : Template
    {
        public static readonly Guid ID = Guid.Parse("f5483dec-5ca6-4663-bb87-c1eb1bcb0779");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Axe Climber",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ddf59ac2-bed7-4411-86b3-db4e95a77890"), Type = TextBlockType.Text, Text = "When you are climbing a wooden surface and have a (item: hatchet) or (item: battle axe) in each hand, you have a climb Speed equal to half your normal Speed. You must still have both legs available to climb and can’t use either of the axes in combat while climbing. This feat can also be used to climb a surface of ice if you have a (item: light pick) in each hand." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cba6aabd-4114-4ad0-af71-36bc755b5474"), Feats.Instances.TurpinRoweLumberjackDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f5e6341b-1486-4822-acde-b94b478188bf"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
