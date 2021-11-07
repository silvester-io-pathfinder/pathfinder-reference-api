using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpecializedCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("793e690c-8231-4cca-a7aa-c78ef722eb96");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Specialized Companion",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e07c50f6-f40a-4b96-8b78-c50208056cf5"), Type = TextBlockType.Text, Text = "The animal companion you gain from the (feat: Animal Trainer Dedication) feat gains one specialization of your choice (page 217). Increase its proficiency rank in Performance to legendary instead of one of the specialization’s skill increases." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("822eb15e-94a2-45d2-a33d-5ae457cb5fdb"), Feats.Instances.SplendidCompanion.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("47c13ab9-f827-491c-a738-6d364ac62528"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
