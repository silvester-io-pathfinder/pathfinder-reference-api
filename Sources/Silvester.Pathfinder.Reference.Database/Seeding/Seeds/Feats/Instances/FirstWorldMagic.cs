using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FirstWorldMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("96f75e6f-3860-4331-8ad2-4b9e797b0617");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "First World Magic",
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
            yield return new TextBlock { Id = Guid.Parse("67e6ca5c-55fc-4ea8-bc89-6f2bdfbef282"), Type = TextBlockType.Text, Text = "Your connection to the First World grants you a primal innate spell, much like those of the fey. Choose one cantrip from the primal spell list. You can cast this spell as a primal innate spell at will. A cantrip is heightened to a spell level equal to half your level rounded up." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("43b6c216-7fb5-437c-bf96-4126d9bcf0e3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
