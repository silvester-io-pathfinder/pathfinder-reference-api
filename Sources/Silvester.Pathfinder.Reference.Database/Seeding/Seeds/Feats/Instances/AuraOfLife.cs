using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AuraOfLife : Template
    {
        public static readonly Guid ID = Guid.Parse("451c34d4-b2fe-4291-8943-ff542bbb9c38");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aura of Life",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0024d876-5482-407c-8834-313aad216f4d"), Type = TextBlockType.Text, Text = "Your aura protects against necromantic effects. You and all allies within 15 feet gain resistance 5 to negative energy and a +1 status bonus to saves against necromancy effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("41908bc6-6e8a-4ed5-a101-56f1f2f7a165"), Feats.Instances.ShiningOath.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2555f84e-01db-459b-8d40-13840f2e05f7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
