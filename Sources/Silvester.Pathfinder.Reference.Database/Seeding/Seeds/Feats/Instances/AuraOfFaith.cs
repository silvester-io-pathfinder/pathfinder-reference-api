using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AuraOfFaith : Template
    {
        public static readonly Guid ID = Guid.Parse("faeb9f53-f627-43a7-8ae0-cfbe67b4f3b3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aura of Faith",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d8189afa-579c-4c8d-84f1-0d2ce70a4c04"), Type = TextBlockType.Text, Text = "You radiate an aura of pure belief that imbues your attacks and those of nearby allies with holy power. Your (action: Strikes | Strike) deal an extra 1 good damage against evil creatures. Also, each good-aligned ally within 15 feet gains this benefit on their first (action: Strike) that hits an evil creature each round." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificTenet(Guid.Parse("d0b70d12-9ed4-4a88-bca5-003141a11207"), Tenets.Instances.Good.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4f96fcdc-2257-4ce5-a94d-c802baf8f2db"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
