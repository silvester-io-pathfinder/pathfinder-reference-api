using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CleverGambit : Template
    {
        public static readonly Guid ID = Guid.Parse("bbab2ab5-8234-423e-b2b6-408453946773");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Clever Gambit",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your Strike critically hits and deals damage to a creature you've identified with Recall Knowledge.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d28df336-c05c-43d6-8c3f-00f3107dca6d"), Type = TextBlockType.Text, Text = "Your battle tactics are aided by your assessment of your foes’ capabilities, allowing you to instantly adjust your movements to maximum advantage. You (action: Step) or (action: Stride); this movement doesn’t trigger reactions from the triggering creature." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3f7111d2-5842-4360-a7d9-5411292c0fcb"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
