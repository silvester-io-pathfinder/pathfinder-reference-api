using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShadowcasterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("2bd3ec77-7024-4151-b797-29db218e549c");

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
            yield return new TextBlock { Id = Guid.Parse("40a64637-2760-4ee7-a8ee-f2aad5b3a386"), Type = TextBlockType.Text, Text = $"You've sacrificed a piece of your spirit, allowing the powers of shadow into your being and changing the nature of your magic. You can no longer cast spells that have the {ToMarkdownLink<Models.Entities.Trait>("light", Traits.Instances.Light.ID)} trait; if an ability, such as a class feature or ancestry feat, would automatically grant you a light spell, such as the {ToMarkdownLink<Models.Entities.Feat>("Domain Initiate", Feats.Instances.DomainInitiate.ID)} feat granting you the {ToMarkdownLink<Models.Entities.Spell>("dazzling flash", Spells.Instances.DazzlingFlash.ID)} spell, you don't gain that spell." };
            yield return new TextBlock { Id = Guid.Parse("e1ee25e3-b277-4835-ab37-44df3968760c"), Type = TextBlockType.Text, Text = $"You gain the {ToMarkdownLink<Models.Entities.Spell>("cloak of shadow", Spells.Instances.CloakOfShadow.ID)} domain spell. It costs 1 Focus Point to cast a focus spell. This feat grants a focus pool of 1 Focus Point that you can recover using the {ToMarkdownLink<Models.Entities.Activity>("Refocus", Activities.Instances.Refocus.ID)} activity. You can {ToMarkdownLink<Models.Entities.Activity>("Refocus", Activities.Instances.Refocus.ID)} by meditating to siphon power from the Shadow Plane and refill your focus pool. Your domain spells from the shadowcaster archetype are of the same tradition as the spells you used to meet the shadowcaster archetype's prerequisites." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyMagicTradition(Guid.Parse("56a3d7a3-6b36-4d74-918a-3dc9dc23de04"));
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("738012ed-d442-43e6-a569-ae716539f7af"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
