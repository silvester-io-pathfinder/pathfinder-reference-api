using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Thrash : Template
    {
        public static readonly Guid ID = Guid.Parse("4f5da65f-c651-4c4f-b419-8b093bcc5e9b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Thrash",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0bedcbca-365c-424a-a995-08842688a259"), Type = TextBlockType.Text, Text = "You thrash the grabbed foe around. It takes bludgeoning damage equal to your Strength modifier plus your weapon specialization damage plus your (feat: Rage) damage. The foe must attempt a basic Fortitude save against your class DC." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("33fb704b-91f9-4802-a9e9-90d591aa8b5c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
