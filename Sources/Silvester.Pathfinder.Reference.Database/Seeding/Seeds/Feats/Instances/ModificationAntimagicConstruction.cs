using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationAntimagicConstruction : Template
    {
        public static readonly Guid ID = Guid.Parse("028e8203-a4c5-41be-8976-cfd7bedd6314");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Antimagic Construction",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("91898aea-ecc3-4459-a53c-70599328933c"), Type = TextBlockType.Text, Text = "Whether you used some clever adaptation of the magic-negating skymetal known as noqual or created magical protections entirely of your own devising, you’ve made your innovation highly resilient to spells. Your construct innovation gains a +2 circumstance bonus to all saving throws and AC against spells." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d1e3c5c-f6b0-4442-b833-01349d637b2d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
