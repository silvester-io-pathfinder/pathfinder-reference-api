using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShadowMaster : Template
    {
        public static readonly Guid ID = Guid.Parse("7bb97708-4ba9-4976-aaa1-b5c592440d94");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shadow Master",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("31306d94-c29e-4253-9938-f21721f58257"), Type = TextBlockType.Text, Text = "The shadows protect you better than any armor can, and they give you power to plunge others into darkness. Whenever you are in an area of dim light or darkness, you gain resistance 5 to all damage except force and damage from (action: Strikes | Strike) with the (item: ghost touch | Ghost Touch Runestone) property rune. When you attempt a Reflex saving throw in an area of dim light or darkness, you can roll twice and take the higher result; this is a (trait: fortune) effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("47cccbfc-10ec-4a87-8234-5befdb7742e8"), Feats.Instances.ShadowdancerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("abfe10a2-8de7-4d53-b0de-125de081e6ec"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
