using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LoudSinger : Template
    {
        public static readonly Guid ID = Guid.Parse("20747ee1-da48-4bd2-866b-fdd5c7100821");

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
            yield return new TextBlock { Id = Guid.Parse("3ccb1cc8-9b79-4b50-997a-20da73bf69b2"), Type = TextBlockType.Text, Text = "Staying on pitch, proper breath control, and remembering the words are all less important than the real measure of a good singer: volume! The range of your (feat: Goblin Song) is increased to 60 feet, and you can target one additional enemy when you use it." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b6cc2cfd-65c2-44bf-8410-d5bfe34d4d21"), Feats.Instances.GoblinSong.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3bfa3c3c-ff0e-43ed-bf1e-962b117446ab"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
