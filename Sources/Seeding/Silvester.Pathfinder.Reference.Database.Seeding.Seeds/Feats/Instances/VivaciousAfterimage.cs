using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VivaciousAfterimage : Template
    {
        public static readonly Guid ID = Guid.Parse("9847cd5d-63bc-4dd5-820f-62f996213094");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vivacious Afterimage",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("18cbb9f5-0bf6-430c-9f39-f4a0b26faf39"), Type = TextBlockType.Text, Text = $"You move so quickly that you create a short-lived afterimage, looks exactly like you, in front of you or behind you. You {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)}. At any point along your movement, you leave an afterimage of yourself behind. Alternatively, you can stop moving and send your afterimage forward instead, up to the remainder of your Speed. A creature that spends actions to engage with your afterimage can attempt to disbelieve it with a Will save against your class DC. Once an enemy has disbelieved any of your afterimages, they are temporarily immune to all of your Vivacious Afterimages for 10 minutes. As long as a creature has not disbelieved the afterimage, the afterimage counts as a creature for flanking. The afterimage lasts until the beginning of your next turn or until you use Vivacious Afterimage again, whichever comes first." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("b8e1c605-5d8e-4d5f-98c2-c9c94246e5a5"), ClassFeatures.Swashbucklers.VivaciousSpeed.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1dc609f5-0722-4618-b62b-4c1e44ced114"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
