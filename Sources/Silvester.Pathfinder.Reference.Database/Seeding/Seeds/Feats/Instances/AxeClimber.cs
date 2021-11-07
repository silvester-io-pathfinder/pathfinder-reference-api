using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AxeClimber : Template
    {
        public static readonly Guid ID = Guid.Parse("3fd26528-91cb-4ae2-abb9-728c41e0c690");

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
            yield return new TextBlock { Id = Guid.Parse("a213e9f6-a6f3-4134-9889-b0a71e6da2ca"), Type = TextBlockType.Text, Text = "When you are climbing a wooden surface and have a (item: hatchet) or (item: battle axe) in each hand, you have a climb Speed equal to half your normal Speed. You must still have both legs available to climb and can’t use either of the axes in combat while climbing. This feat can also be used to climb a surface of ice if you have a (item: light pick) in each hand." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9986ccdf-e8a6-496b-932b-41513e8a0561"), Feats.Instances.TurpinRoweLumberjackDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("61565ba8-a744-426f-a059-435fa5d68583"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
