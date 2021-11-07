using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VirgaMay : Template
    {
        public static readonly Guid ID = Guid.Parse("f3a16c4d-72b2-42e4-8215-8d91b94e6f39");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Virga May",
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
            yield return new TextBlock { Id = Guid.Parse("123c53cb-ede3-4ad5-ae8b-dc43724afc88"), Type = TextBlockType.Text, Text = "Born of a storm hag, you have one crystal-blue or rain-gray eye. You share your mother’s power over wind and storm. You can cast (spell: electric arc) as an occult innate cantrip. As normal, a cantrip is heightened to a spell level equal to half your level rounded up." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bd22ca6f-017c-4ffb-9974-5f0c23090152"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
