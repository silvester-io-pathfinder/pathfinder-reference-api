using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EldritchResearcherDedicationOccult : Template
    {
        public static readonly Guid ID = Guid.Parse("24b0325d-d8ec-48d9-95c3-41491a28388b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eldritch Researcher Dedication - Occult",
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
            yield return new TextBlock { Id = Guid.Parse("df67fbe1-9e09-4930-a01f-c2283b6a5192"), Type = TextBlockType.Text, Text = "You gain the ability to cast a single occult cantrip of your choice. If you weren&#39;t already, you become trained in occult spell DCs and spell attack rolls with Intelligence as your spellcasting ability." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9db76837-cf72-4bfe-88c1-c1198c31ea5e"),
                SourceId = Sources.Instances.AbominationVaults.ID,
                Page = -1
            };
        }
    }
}
