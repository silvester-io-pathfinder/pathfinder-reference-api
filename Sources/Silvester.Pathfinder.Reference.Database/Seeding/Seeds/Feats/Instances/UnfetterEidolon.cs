using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnfetterEidolon : Template
    {
        public static readonly Guid ID = Guid.Parse("07661190-ba35-418c-aa39-aaba23dfd09e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unfetter Eidolon",
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
            yield return new TextBlock { Id = Guid.Parse("7943be2b-b50f-4956-b2ca-1faaed9f7177"), Type = TextBlockType.Text, Text = "You can allow your eidolon to travel far from your side. You learn the (spell: unfetter eidolon) link spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("301c05f6-d216-44f7-a659-f1387fb3c4cf"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
