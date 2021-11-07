using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Dedication : Template
    {
        public static readonly Guid ID = Guid.Parse("f647677c-6fbc-4e55-b21a-ba38e6b52db5");

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
            yield return new TextBlock { Id = Guid.Parse("ef3e0b81-c814-4a69-902a-2f3196b8fad1"), Type = TextBlockType.Text, Text = "Your commitment protects those you are dedicated to but can lead to dependency. Your (feat: emotional focus) is an individual creature you’re bound to." };
            yield return new TextBlock { Id = Guid.Parse("da82ecd2-11de-4202-b294-9ffa61783cb1"), Type = TextBlockType.Text, Text = "~ Catharsis Trigger: Your emotional focus takes damage from an enemy while within 30 feet of you." };
            yield return new TextBlock { Id = Guid.Parse("16362ee6-f9d6-4e24-a0cf-ae7b2bc931fb"), Type = TextBlockType.Text, Text = "~ Catharsis Activation: Your emotional focus gains a number of temporary Hit Points equal to half your level rounded up. These temporary HP last for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("62a25ca5-030e-42f2-b243-b166ad6f525f"), Type = TextBlockType.Text, Text = "~ Emotional Fervor: Your spells that target your emotional focus gain the benefits of (feat: Reach Spell). When you cast a healing spell that affects your emotional focus, your emotional focus also gains temporary HP equal to the spell’s level in addition to the spell’s effects. These temporary HP last for 1 minute. Spell: (spell: spirit link)" };
            yield return new TextBlock { Id = Guid.Parse("b617a6eb-4c20-474a-8fd3-a02cf53d0c10"), Type = TextBlockType.Text, Text = "~ Emotional Fallout: Until you (feat: Settle your Emotions|Settle emotions), you can’t (action: Cast Spells|Cast a Spell) unless you’re adjacent to your emotional focus." };
            yield return new TextBlock { Id = Guid.Parse("68364fd0-05c3-4885-be5e-5960e772209d"), Type = TextBlockType.Text, Text = "~ Focus Spell: (spell: protector’s sacrifice)" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("65bbb926-ba3e-4d4d-9adc-0c2c1e496b06"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
