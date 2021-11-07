using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VivaciousAfterimage : Template
    {
        public static readonly Guid ID = Guid.Parse("aaddee53-81d4-47d2-9a90-72fabd90f8d6");

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
            yield return new TextBlock { Id = Guid.Parse("7d8a7bdd-8f54-477c-ad7f-4a6ea6ab6214"), Type = TextBlockType.Text, Text = "You move so quickly that you create a short-lived afterimage, looks exactly like you, in front of you or behind you. You (action: Stride). At any point along your movement, you leave an afterimage of yourself behind. Alternatively, you can stop moving and send your afterimage forward instead, up to the remainder of your Speed. A creature that spends actions to engage with your afterimage can attempt to disbelieve it with a Will save against your class DC. Once an enemy has disbelieved any of your afterimages, they are temporarily immune to all of your Vivacious Afterimages for 10 minutes. As long as a creature has not disbelieved the afterimage, the afterimage counts as a creature for flanking. The afterimage lasts until the beginning of your next turn or until you use Vivacious Afterimage again, whichever comes first." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("55ee02cc-ad8e-463e-bded-c270a1a99df8"), ClassFeatures.Swashbucklers.VivaciousSpeed.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("872eae0c-ab8c-415d-8a11-db49b16e0819"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
