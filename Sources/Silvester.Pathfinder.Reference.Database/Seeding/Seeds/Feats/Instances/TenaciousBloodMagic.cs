using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TenaciousBloodMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("12d3935d-e826-481c-9c18-d6a1aecb6fef");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tenacious Blood Magic",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You apply an effect from your blood magic that lasts for 1 round.",
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("de4509ec-6a19-4386-8285-e9d78f919d6b"), Type = TextBlockType.Text, Text = "You have learned how to invest magic more deeply by witnessing Aroden’s works. The triggering blood magic effect lasts for 1 minute instead of 1 round." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d8a54bf6-bb1a-426e-94c9-e65041ff160a"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
