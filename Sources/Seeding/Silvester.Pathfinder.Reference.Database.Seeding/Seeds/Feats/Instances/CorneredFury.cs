using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CorneredFury : Template
    {
        public static readonly Guid ID = Guid.Parse("d40c5992-64f4-400f-9d0d-c31f98dd3841");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cornered Fury",
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
            yield return new TextBlock { Id = Guid.Parse("95e4bb62-1e51-46e4-8a5f-968bdced5908"), Type = TextBlockType.Text, Text = "When physically outmatched, you fight with unexpected ferocity. If a foe of a larger size than you critically hits and damages you, that foe is flat-footed to you for 1 round." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("95486bab-3aa6-4dd1-80bf-2b809953ea21"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
