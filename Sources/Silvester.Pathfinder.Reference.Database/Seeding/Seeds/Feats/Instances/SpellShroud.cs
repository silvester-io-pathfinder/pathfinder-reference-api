using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpellShroud : Template
    {
        public static readonly Guid ID = Guid.Parse("3ba4cda1-d303-4a9b-99d4-dcd92f2e419d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spell Shroud",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("86424ee1-2ee8-41f6-9a89-645efd34ef5f"), Type = TextBlockType.Text, Text = "Your spell shrouds you in a billowing cloud. If your next action is to (activity: Cast a Spell) that targets you, you surround yourself in a 15-foot emanation of dense magical mist that lasts until the start of your next turn. All creatures within the cloud become concealed, and all creatures outside the cloud are concealed to creatures within it." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b88a22ec-965c-4c4b-8801-c94dfe838ffb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
