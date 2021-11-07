using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConcentratedAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("47f30009-b158-4d69-8693-80208be9e83d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Concentrated Assault",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2e73a909-4b86-4a32-b4ea-888c8e98643d"), Type = TextBlockType.Text, Text = "You and your spotter combine your efforts to bring down your target. If you and your spotter both use the Ready activity to make a (action: Strike) against the same opponent and choose the same trigger for the readied action, resolve your attacks at the same time. Each of you can use the higher of the two attack rolls for your (action: Strikes|Strike), each using your own modifier; this is a (trait: fortune) effect. If both attacks are successful, total the damage for both attacks for the purpose of resistances and weaknesses." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("32df7bae-8b32-4c4d-8217-b1bc737f6055"), Feats.Instances.SnipingDuoDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b8ca2409-1e3c-4627-8500-20624c5853a5"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
