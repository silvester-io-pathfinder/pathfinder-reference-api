using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HouseOfImaginaryWalls : Template
    {
        public static readonly Guid ID = Guid.Parse("137c59c2-a95e-4f89-b43e-18545b0c9816");

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
            yield return new TextBlock { Id = Guid.Parse("27bdf05d-3ffd-4830-9456-1a435253746d"), Type = TextBlockType.Text, Text = "You erect an imaginary barrier others believe to be real. You learn the (spell: house of imaginary walls) composition cantrip." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2cc739ec-8ae1-4c12-a0d1-ab82c5bed1de"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
