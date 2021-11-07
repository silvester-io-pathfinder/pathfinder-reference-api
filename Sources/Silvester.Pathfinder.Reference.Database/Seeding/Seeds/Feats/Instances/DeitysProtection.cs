using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeitysProtection : Template
    {
        public static readonly Guid ID = Guid.Parse("481905b9-5af1-4a59-a38c-19eeaac4260e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deity's Protection",
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
            yield return new TextBlock { Id = Guid.Parse("0e6f4878-61ce-4bd9-9905-1423013e7a9d"), Type = TextBlockType.Text, Text = "When you call upon your deity’s power to fulfill the promise of their domain, you gain divine protection. After you cast a domain spell, you gain resistance to all damage until the start of your next turn. The amount of resistance is equal to the level of the domain spell you cast." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("067b52db-b159-4369-8134-d78e53c33326"), Feats.Instances.AdvancedDomain.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("15b086cd-3398-438b-bf8b-d9d0613a50fc"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
