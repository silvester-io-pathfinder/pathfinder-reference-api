using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TrueGaze : Template
    {
        public static readonly Guid ID = Guid.Parse("6722b589-6ca5-483c-8a08-8b4540b39d4a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "True Gaze",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per hour"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ee39312c-cac8-4197-8073-aae4f77e56ab"), Type = TextBlockType.Text, Text = "When you focus your eyes carefully, your gaze can pierce through all obfuscations, even magical ones. When you use True Gaze, you gain the effects of a 6th-level (spell: true seeing) spell, using your Perception modifier for the counteract check." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c9efa49-1c42-4974-82af-25f55d6a2f9a"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
