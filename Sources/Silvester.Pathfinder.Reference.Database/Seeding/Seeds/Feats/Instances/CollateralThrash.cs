using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CollateralThrash : Template
    {
        public static readonly Guid ID = Guid.Parse("f422b027-350d-4e5c-b871-af40048b6c67");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Collateral Thrash",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("97b7c424-da62-4ec0-b876-31207a00abdf"), Type = TextBlockType.Text, Text = "When you (feat: Thrash) a grabbed foe, you smack that foe into another nearby. Another foe adjacent to the grabbed foe also takes your (feat: Thrash) damage, with a basic Reflex save against your class DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fa7bb722-a52d-4fa9-ae1a-d1148a32c507"), Feats.Instances.Thrash.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d62dee74-732f-4702-8616-04f5440493c8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
