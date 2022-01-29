using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RemoteTrigger : Template
    {
        public static readonly Guid ID = Guid.Parse("e8ff5543-ac70-41be-8809-a3244dec34f5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Remote Trigger",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bc157c9b-8627-4e9a-b872-f4576b7f78a8"), Type = TextBlockType.Text, Text = $"You've learned how to trigger snares from afar, creating ranged hazards to assail your opponents and allowing you to disarm enemies' snares harmlessly. You can {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} a snare to trigger it prematurely. If you crafted the snare, you automatically hit. If someone else crafted it, attempt a ranged {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against the Crafting DC, triggering the snare only if you hit." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2269b4a6-77bb-49c4-a7a6-ea301bfc316c"), Feats.Instances.SnarecrafterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("33dc36dc-3662-4c43-bb1c-cfc3aae84279"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
