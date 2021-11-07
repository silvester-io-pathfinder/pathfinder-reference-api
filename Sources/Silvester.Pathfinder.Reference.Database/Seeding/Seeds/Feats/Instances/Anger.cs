using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Anger : Template
    {
        public static readonly Guid ID = Guid.Parse("a9bd00d7-7330-4e9b-8804-105a97a660a0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Anger",
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
            yield return new TextBlock { Id = Guid.Parse("490bc8c8-8293-4086-af8a-1287702a8a1a"), Type = TextBlockType.Text, Text = "Your destructive wrath allows you to harm your foes but causes you pain in the process." };
            yield return new TextBlock { Id = Guid.Parse("9e80a6ff-e800-4798-91c3-17500d0bd10b"), Type = TextBlockType.Text, Text = "~ Catharsis Trigger: An enemy deals damage to you. You can’t use this reaction if you’re fatigued." };
            yield return new TextBlock { Id = Guid.Parse("b97dd261-f5e7-4866-a891-66e22943d4a3"), Type = TextBlockType.Text, Text = "~ Catharsis Activation: If you’re grabbed, immobilized, or restrained, you can attempt to (action: Escape). If you succeed, the creature or hazard imposing the condition on you (if applicable) takes force damage equal to your level." };
            yield return new TextBlock { Id = Guid.Parse("d1ad56cf-b7fd-453a-98d3-b11770dc6c67"), Type = TextBlockType.Text, Text = "~ Emotional Fervor: When you (action: Cast a Spell) from your spell slots, if the spell deals damage and doesn’t have a duration, you gain a status bonus to that spell’s damage equal to the spell’s level. Spell: (spell: draw ire)" };
            yield return new TextBlock { Id = Guid.Parse("2f26e2fb-e3e0-493b-9537-2199c9fbd5f9"), Type = TextBlockType.Text, Text = "~ Emotional Fallout: You become fatigued until you (feat: Settle your Emotions | Settle Emotions)." };
            yield return new TextBlock { Id = Guid.Parse("44a5146e-e128-47c2-9e36-59d72321819b"), Type = TextBlockType.Text, Text = "~ Focus Spell: (spell: athletic rush)" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e81ace04-8faf-426a-bd66-2b61a07d669c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
