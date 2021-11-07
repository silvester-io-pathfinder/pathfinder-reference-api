using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FlameJump : Template
    {
        public static readonly Guid ID = Guid.Parse("da8e26ce-ff94-45bd-acb1-03177b5451fd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flame Jump",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("00242d2b-f004-4cbb-b2a2-04c28dbc72a4"), Type = TextBlockType.Text, Text = "Your peri lineage has opened your mind to fire’s raw, purging essence. You can spend 1 minute in focused preparation, then enter a fire your size or larger to instantly teleport to any fire that is your size or larger up to 5 miles away. You take no damage from entering or exiting fires when using this ability. Once you enter the fire, you instantly know the rough locations of other large fires within range and can exit from the original fire, if you prefer. You can’t carry (trait: extradimensional) spaces with you when you teleport; if you attempt to do so, the activity fails." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7f88a52e-ef43-4f94-ae84-a1904d7cae25"), Feats.Instances.Emberkin.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("18b3df49-a030-470c-8207-4f25e288d4c8"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
