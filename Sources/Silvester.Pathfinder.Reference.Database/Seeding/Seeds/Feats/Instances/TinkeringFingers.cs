using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TinkeringFingers : Template
    {
        public static readonly Guid ID = Guid.Parse("5c12828b-8aae-4f94-8baa-695342ac3946");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tinkering Fingers",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("13134db0-5035-48ec-a54b-c3f23aa20bab"), Type = TextBlockType.Text, Text = "You&#39;re good with your hands and can quickly improvise a fix for broken or damaged equipment. You&#39;re trained in Crafting. If you would automatically become trained in Crafting (from your background or class, for example), you instead become trained in a skill of your choice. You can (action: Repair) an item without using a (item: repair kit) without taking the -2 circumstance penalty, improvising tools from whatever you have at hand." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("da105d58-5d3d-4d3b-86ca-9f513af2a234"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
