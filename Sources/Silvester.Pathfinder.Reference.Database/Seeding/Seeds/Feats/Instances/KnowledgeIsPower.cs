using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KnowledgeIsPower : Template
    {
        public static readonly Guid ID = Guid.Parse("8f2b9d21-f7e5-4356-b069-6e0579471683");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Knowledge is Power",
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
            yield return new TextBlock { Id = Guid.Parse("4379e465-2b3d-4045-953a-0d3ca6956040"), Type = TextBlockType.Text, Text = "When you critically succeed at a (action: Recall Knowledge) check about a creature, you gain a +1 circumstance bonus to your next attack roll against the creature, to your AC against its next attack roll, and to your save against its next effect requiring a save. If you share this information with your allies, they gain the benefits as well. If not used, these bonuses end after 1 minute." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4b55784e-5c0c-4dd7-818b-0f5f904bb7a9"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
