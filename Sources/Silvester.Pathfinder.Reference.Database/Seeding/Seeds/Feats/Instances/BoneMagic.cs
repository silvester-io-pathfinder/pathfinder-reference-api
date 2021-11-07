using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BoneMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("d0cc6853-36e6-45fa-ad7f-b32749ac6d9c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bone Magic",
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
            yield return new TextBlock { Id = Guid.Parse("f3f92872-1d6d-458d-9422-f1127614590e"), Type = TextBlockType.Text, Text = "Your connection to your iruxi ancestors manifests as a simple primal spell that you cast using a fragment of an ancestor’s bones. Choose one cantrip from the primal spell list. You can cast this cantrip as a primal innate spell at will, and it’s heightened to a spell level equal to half your level rounded up." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7cc320ae-76fa-4f32-ba6b-5de4cf9f941f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
