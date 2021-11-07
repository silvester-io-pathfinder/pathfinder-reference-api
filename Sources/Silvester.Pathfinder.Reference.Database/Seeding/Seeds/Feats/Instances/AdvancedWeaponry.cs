using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdvancedWeaponry : Template
    {
        public static readonly Guid ID = Guid.Parse("96b57916-470c-471d-ad53-5cd4ae0097bb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Advanced Weaponry",
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
            yield return new TextBlock { Id = Guid.Parse("ba4aa4a7-6eaf-4f7e-b21a-0493f42fb334"), Type = TextBlockType.Text, Text = "Your eidolon’s attack evolves. Choose one of your eidolon’s starting melee unarmed attacks. It gains one of the following traits, chosen when you gain the feat: (trait: disarm), (trait: grapple), (trait: nonlethal), (trait: shove), (trait: trip), or (trait: versatile bludgeoning | versatile b), (trait: piercing | versatile p), or (trait: slashing | versatile s)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("37383233-8f0a-4404-915e-d244af95a6f2"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
