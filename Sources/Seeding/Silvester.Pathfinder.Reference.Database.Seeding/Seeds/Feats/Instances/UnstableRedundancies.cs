using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnstableRedundancies : Template
    {
        public static readonly Guid ID = Guid.Parse("95f5b342-da64-482f-9104-62815522133b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unstable Redundancies",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You would attempt the flat check for an unstable action, but you haven't rolled the flat check yet.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("77ffed67-c3dc-456a-95a6-52bf690cfbad"), Type = TextBlockType.Text, Text = "You’ve built triple redundancies into your innovation and added all sorts of buffers to protect it from the harm of your unstable experiments. You automatically succeed at the triggering flat check." };
            yield return new TextBlock { Id = Guid.Parse("425cda7b-7b0d-4ace-b8a3-1a739969bb6b"), Type = TextBlockType.Text, Text = "You can’t rely on your Unstable Redundancies again until you spend 10 minutes setting them back up. If you spend 10 minutes retuning your innovation so you can use (trait: unstable) actions again, you can set up your Unstable Redundancies during the same time." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6fb20675-c207-4cee-b733-c1d1273f1fb4"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
