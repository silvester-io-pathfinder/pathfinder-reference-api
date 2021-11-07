using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Allegro : Template
    {
        public static readonly Guid ID = Guid.Parse("26dd6160-76ed-4101-9358-51ac1ed71068");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Allegro",
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
            yield return new TextBlock { Id = Guid.Parse("558550c7-1c53-4f82-a23c-50bc9246f104"), Type = TextBlockType.Text, Text = "You can quicken your allies with a fast-paced performance. You learn the (spell: allegro) composition cantrip." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1b0e935d-1ae7-4625-8384-bb66aecfdac7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
