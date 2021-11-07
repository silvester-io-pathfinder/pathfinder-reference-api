using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SCDanceOfDarkness : Template
    {
        public static readonly Guid ID = Guid.Parse("8bb16002-ae23-4e31-ba5d-a091f9c4e20e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "SC - Dance of Darkness",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d3d5f50d-586c-4a96-a958-0dcadd98f581"), Type = TextBlockType.Text, Text = "You learn the (spell: dance of darkness) shadowdancer focus spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6458e0af-583d-408c-97e1-2e8649a158f1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
