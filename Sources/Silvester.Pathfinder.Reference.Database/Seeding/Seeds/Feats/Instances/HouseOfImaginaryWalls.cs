using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HouseOfImaginaryWalls : Template
    {
        public static readonly Guid ID = Guid.Parse("785853e3-6b53-4bcf-b106-09c9208c57c5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "House of Imaginary Walls",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0d9fe426-bdc6-419f-9414-5888af243895"), Type = TextBlockType.Text, Text = "You erect an imaginary barrier others believe to be real. You learn the (spell: house of imaginary walls) composition cantrip." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("32d16ed9-7b6e-4c30-9787-d16d6fd45f8a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
