using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InsectShape : Template
    {
        public static readonly Guid ID = Guid.Parse("5f66d981-c16e-45ae-9a3d-e8069e5d4f11");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Insect Shape",
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
            yield return new TextBlock { Id = Guid.Parse("37d9786c-3ab2-4742-9a59-e4b0d6549398"), Type = TextBlockType.Text, Text = "Your understanding of life expands, allowing you to mimic a wider range of creatures. Add the forms in insect form to your wild shape list. Whenever you use (Spell: wild shape) to polymorph into the non-flying insect form listed in (Spell: pest form), the duration is 24 hours instead of 10 minutes." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f54116d2-552e-4e67-b79b-ee4bc1155efe"), Feats.Instances.WildShape.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("20c79272-011d-40c0-b31e-01d622d1434c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
