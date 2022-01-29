using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShareSenses : Template
    {
        public static readonly Guid ID = Guid.Parse("4081c69c-eacc-4ef2-9512-4ec3799c2379");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Share Senses",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "This action has the trait matching your eidolon's tradition ((trait: arcane), (trait: divine), (trait: occult), or (trait: primal)). Your eidolon can also use this ability. When it does, it projects its senses into your body.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("be5a1f3f-7b98-4644-8a05-5fb98cfe382e"), Type = TextBlockType.Text, Text = $"You project your senses into your eidolon, allowing you to perceive through it. When you do, you lose all sensory information from your own body, but can sense through your eidolon's body for up to 1 minute. You can {ToMarkdownLink<Models.Entities.Action>("Dismiss", Actions.Instances.Dismiss.ID)} this effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3736a7f3-4bdb-49a1-a396-fffd1eb12676"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
