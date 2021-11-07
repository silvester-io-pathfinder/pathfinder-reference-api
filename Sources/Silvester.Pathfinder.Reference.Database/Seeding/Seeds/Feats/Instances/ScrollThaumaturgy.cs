using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScrollThaumaturgy : Template
    {
        public static readonly Guid ID = Guid.Parse("f28cdcdd-78e8-412c-9fcc-c5ed0578a889");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scroll Thaumaturgy",
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
            yield return new TextBlock { Id = Guid.Parse("b1205549-85d6-4d66-aad1-5fb29986cdc9"), Type = TextBlockType.Text, Text = "Your multidisciplinary study of magic means you know how to activate the magic in scrolls with ease. You can Activate scrolls of any magical tradition, using your thaumaturge class DC for the scroll’s DC, rather than a particular spell DC. If a spell is on the spell list for multiple traditions, you choose which tradition to use at the time you Activate the scroll." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5169f1ed-98fc-4598-8604-6a35e9f96498"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
