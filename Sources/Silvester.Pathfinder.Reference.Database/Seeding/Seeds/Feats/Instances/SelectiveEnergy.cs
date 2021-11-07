using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SelectiveEnergy : Template
    {
        public static readonly Guid ID = Guid.Parse("d0166f0d-d52d-40f3-92d1-0aaa05d10648");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Selective Energy",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2bf08579-59b3-4a7b-9785-ecaaca4c5fea"), Type = TextBlockType.Text, Text = "As you call down divine power, you can prevent some enemies from benefiting or some allies from being hurt. When you cast a version of (spell: harm) or (spell: heal) that has an area, you can designate a number of creatures equal to your Charisma modifier (minimum 1) that are not targeted by the spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de8a59c2-b4ea-4828-bb31-6096afd4a254"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
