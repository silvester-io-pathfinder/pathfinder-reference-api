using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AberrationKinship : Template
    {
        public static readonly Guid ID = Guid.Parse("312badc1-8554-4cfb-a3d5-d434ca0deaf3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aberration Kinship",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7c3e7ea3-97cd-492a-a293-6772820163ba"), Type = TextBlockType.Text, Text = "Your mind resonates with the inscrutable thought processes that inhuman aberrations use to communicate. You can cast (spell: mindlink) as an innate occult spell once per day, but you can target only aberrations." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("62e4d4cd-92b6-4e58-b117-96cb5af7da61"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
