using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LoudSinger : Template
    {
        public static readonly Guid ID = Guid.Parse("9dbe296f-4008-40c3-b84c-0542f056d592");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Loud Singer",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2fe01fe7-324d-4f9d-ad31-54574bf06d85"), Type = TextBlockType.Text, Text = "Staying on pitch, proper breath control, and remembering the words are all less important than the real measure of a good singer: volume! The range of your (feat: Goblin Song) is increased to 60 feet, and you can target one additional enemy when you use it." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f29a6a74-eb68-400d-9189-d3ec3bc889d7"), Feats.Instances.GoblinSong.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4cb9acef-0ccd-444d-9478-9bd7102a7fc6"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
