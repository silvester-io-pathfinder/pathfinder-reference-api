using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NumbToDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("9244013d-7720-4fdb-80e6-fd779ff34684");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Numb to Death",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bfe78d5e-090f-4af4-8e1d-a6c56ba9ffd8"), Type = TextBlockType.Text, Text = "Your past has left you numb to death’s call. The first time each day that you regain Hit Points while you are dying, you regain additional Hit Points equal to your level, and you neither gain the wounded condition nor increase the value of this condition." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("582e0ea4-36e0-4c63-8b2a-d5a318ec91b1"), Feats.Instances.Diehard.ID);
            builder.Manual(Guid.Parse("fe12fb3e-34f7-4071-8963-2cd7be1c5bde"), "You have died at least once.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("58d3c004-42b0-4741-90ea-83e5dcad9b4f"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
