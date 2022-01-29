using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeitysProtection : Template
    {
        public static readonly Guid ID = Guid.Parse("e7e85e39-12c3-423d-9581-62661fa2f905");

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
            yield return new TextBlock { Id = Guid.Parse("f9a867c4-8201-483e-8c81-14d14234a2b3"), Type = TextBlockType.Text, Text = $"When you call upon your deity's power to fulfill the promise of their domain, you gain divine protection. After you cast a domain spell, you gain resistance to all damage until the start of your next turn. The amount of resistance is equal to the level of the domain spell you cast." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fc0519e7-083e-469c-a522-7c0c8f5ff722"), Feats.Instances.AdvancedDomain.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("5a3a0175-9436-4f00-a11d-254a963e0c8a"), Traits.Instances.Cleric.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e34e1f37-e782-4d3d-b14f-44f4fd54f31e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
