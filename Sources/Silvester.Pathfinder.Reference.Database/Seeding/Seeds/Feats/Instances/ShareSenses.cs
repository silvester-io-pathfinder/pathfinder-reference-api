using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShareSenses : Template
    {
        public static readonly Guid ID = Guid.Parse("7cfd4fca-ef11-422c-9211-e94d3afc307a");

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
            yield return new TextBlock { Id = Guid.Parse("b4fbb0cc-c0ae-4e8c-8174-358a7fed7669"), Type = TextBlockType.Text, Text = "You project your senses into your eidolon, allowing you to perceive through it. When you do, you lose all sensory information from your own body, but can sense through your eidolon’s body for up to 1 minute. You can (action: Dismiss) this effect." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b2c35ee7-172f-46bb-828d-c62f32b555e1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
