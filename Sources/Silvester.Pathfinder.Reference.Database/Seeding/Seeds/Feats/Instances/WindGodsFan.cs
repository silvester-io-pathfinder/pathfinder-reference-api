using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WindGodsFan : Template
    {
        public static readonly Guid ID = Guid.Parse("60ef4c37-cbfd-4cb7-a324-9e3959d6ede7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wind God's Fan",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c517373a-97fb-4a27-8edf-20d003a20d58"), Type = TextBlockType.Text, Text = "Your fan can stir up even more powerful winds. You can (action: Activate | Activate an Item) your (item: tengu feather fan) one additional time per day. Add the 3rd-level (spell: wall of wind) spell to the spells contained within your fan." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3947fd1b-3ffd-48be-a716-456aa053e2ff"), Feats.Instances.TenguFeatherFan.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("85d8ade9-34b0-4911-bae8-cbfda2fdbd10"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
