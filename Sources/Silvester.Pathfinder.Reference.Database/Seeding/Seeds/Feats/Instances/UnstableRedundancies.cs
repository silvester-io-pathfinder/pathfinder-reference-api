using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnstableRedundancies : Template
    {
        public static readonly Guid ID = Guid.Parse("fd1d9352-25d9-4073-ad17-3a0d0d026307");

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
            yield return new TextBlock { Id = Guid.Parse("8a6cbe5d-3f69-477d-99f7-5aed83ed2e20"), Type = TextBlockType.Text, Text = "You’ve built triple redundancies into your innovation and added all sorts of buffers to protect it from the harm of your unstable experiments. You automatically succeed at the triggering flat check." };
            yield return new TextBlock { Id = Guid.Parse("f62309e8-b87a-4f83-b83f-8fba0d321b67"), Type = TextBlockType.Text, Text = "You can’t rely on your Unstable Redundancies again until you spend 10 minutes setting them back up. If you spend 10 minutes retuning your innovation so you can use (trait: unstable) actions again, you can set up your Unstable Redundancies during the same time." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f453076f-f5f7-47d1-a7ad-56bb09c32209"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
