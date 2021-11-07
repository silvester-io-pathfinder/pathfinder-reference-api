using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TenLives : Template
    {
        public static readonly Guid ID = Guid.Parse("1e1ac11c-7fcb-4a6e-9a23-d127b1f0a320");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ten Lives",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d168bfad-afd3-4b20-9143-eba9b75a2452"), Type = TextBlockType.Text, Text = "When your character would die, you can attempt a DC 17 flat check. On a success, you’re instead reduced to 0 HP and a dying value 1 less than would normally kill you (typically dying 3). This doesn’t change the result for any other creature affected." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c64ca09a-a98c-432a-8383-cbf07665b6a3"), Feats.Instances.EvadeDoom.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bfcdebda-addb-4c0d-91c6-61eadcf55c99"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
