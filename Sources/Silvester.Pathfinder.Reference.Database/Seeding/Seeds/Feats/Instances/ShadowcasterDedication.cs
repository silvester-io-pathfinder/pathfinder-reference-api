using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShadowcasterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("a0b228ef-644d-42f3-8f24-6f036ae14a46");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shadowcaster Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained two other feats from the shadowcaster archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bb0125c0-5931-4f35-b23b-b5f17ee1f942"), Type = TextBlockType.Text, Text = "You’ve sacrificed a piece of your spirit, allowing the powers of shadow into your being and changing the nature of your magic. You can no longer cast spells that have the (trait: light) trait; if an ability, such as a class feature or ancestry feat, would automatically grant you a light spell, such as the (feat: Domain Initiate) feat granting you the (spell: dazzling flash) spell, you don’t gain that spell." };
            yield return new TextBlock { Id = Guid.Parse("59b3089d-9ae4-45d4-a9b8-0f273ad4280c"), Type = TextBlockType.Text, Text = "You gain the (spell: cloak of shadow) domain spell. It costs 1 Focus Point to cast a focus spell. This feat grants a focus pool of 1 Focus Point that you can recover using the (action: Refocus) activity. You can (action: Refocus) by meditating to siphon power from the Shadow Plane and refill your focus pool. Your domain spells from the shadowcaster archetype are of the same tradition as the spells you used to meet the shadowcaster archetype’s prerequisites." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyMagicTradition(Guid.Parse("590c7564-b91c-4b82-8913-c8079aa1ad98"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("78553077-6182-4079-bf34-e74ce62949ef"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
