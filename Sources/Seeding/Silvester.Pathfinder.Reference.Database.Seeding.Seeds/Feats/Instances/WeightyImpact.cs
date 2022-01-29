using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WeightyImpact : Template
    {
        public static readonly Guid ID = Guid.Parse("e27f08cf-1da4-4d9e-b1a2-59f0af66be17");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Weighty Impact",
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
            yield return new TextBlock { Id = Guid.Parse("a7d02e81-28ce-45f9-a614-77569294df3c"), Type = TextBlockType.Text, Text = $"Your eidolon knocks enemies down. Choose one of the eidolon's unarmed attacks with the {ToMarkdownLink<Models.Entities.Trait>("trip", Traits.Instances.Trip.ID)} trait. It gains the Knockdown action (Bestiary pg. 343) for that attack." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("07e8735a-b8e0-4ecb-8a46-941daa556d36"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
