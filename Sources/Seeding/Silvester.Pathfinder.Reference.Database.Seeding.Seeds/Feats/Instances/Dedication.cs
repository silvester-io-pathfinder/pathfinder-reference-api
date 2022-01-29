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
    public class Dedication : Template
    {
        public static readonly Guid ID = Guid.Parse("ed0139bd-5afc-4f5d-800b-47e697cc3404");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dedication",
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
            yield return new TextBlock { Id = Guid.Parse("008567bf-098b-490f-88df-564f69ebc2d4"), Type = TextBlockType.Text, Text = $"Your commitment protects those you are dedicated to but can lead to dependency. Your {ToMarkdownLink<Models.Entities.Feat>("emotional focus", Feats.Instances.EmotionalFocus.ID)} is an individual creature you're bound to." };
            yield return new TextBlock { Id = Guid.Parse("3ce2d076-ec8e-4094-baaf-f47290af553b"), Type = TextBlockType.Text, Text = $"~ Catharsis Trigger: Your emotional focus takes damage from an enemy while within 30 feet of you." };
            yield return new TextBlock { Id = Guid.Parse("0d0f849e-3f0c-4407-9d92-947df67fd2eb"), Type = TextBlockType.Text, Text = $"~ Catharsis Activation: Your emotional focus gains a number of temporary Hit Points equal to half your level rounded up. These temporary HP last for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("a7d5913e-b85e-458e-87fa-272474195e0c"), Type = TextBlockType.Text, Text = $"~ Emotional Fervor: Your spells that target your emotional focus gain the benefits of {ToMarkdownLink<Models.Entities.Feat>("Reach Spell", Feats.Instances.ReachSpell.ID)}. When you cast a healing spell that affects your emotional focus, your emotional focus also gains temporary HP equal to the spell's level in addition to the spell's effects. These temporary HP last for 1 minute. Spell: {ToMarkdownLink<Models.Entities.Spell>("spirit link", Spells.Instances.SpiritLink.ID)}" };
            yield return new TextBlock { Id = Guid.Parse("a1cdd3c5-6ccf-4af6-968e-aa448bcfcf25"), Type = TextBlockType.Text, Text = $"~ Emotional Fallout: Until you {ToMarkdownLink<Models.Entities.Feat>("Settle your Emotions", Feats.Instances.SettleEmotions.ID)}, you can't {ToMarkdownLink<Models.Entities.Rule>("Cast Spells", Rules.Instances.CastASpell.ID)} unless you're adjacent to your emotional focus." };
            yield return new TextBlock { Id = Guid.Parse("5574469b-7f46-4be0-8c3a-efe6b29bdc40"), Type = TextBlockType.Text, Text = $"~ Focus Spell: {ToMarkdownLink<Models.Entities.Spell>("protector's sacrifice", Spells.Instances.ProtectorsSacrifice.ID)}" };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87d46027-e6b3-441c-aae6-c64e15718208"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
