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
    public class Anger : Template
    {
        public static readonly Guid ID = Guid.Parse("2950a9b5-78b2-46af-af53-b987046175cd");

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
            yield return new TextBlock { Id = Guid.Parse("31bf419c-61ec-4f7c-ac50-bb3be26273d0"), Type = TextBlockType.Text, Text = $"Your destructive wrath allows you to harm your foes but causes you pain in the process." };
            yield return new TextBlock { Id = Guid.Parse("ff813428-681a-4610-bdf2-d52117d847e9"), Type = TextBlockType.Text, Text = $"~ Catharsis Trigger: An enemy deals damage to you. You can't use this reaction if you're fatigued." };
            yield return new TextBlock { Id = Guid.Parse("ff16b67d-86b7-48bc-bd88-34b1520de4c9"), Type = TextBlockType.Text, Text = $"~ Catharsis Activation: If you're grabbed, immobilized, or restrained, you can attempt to {ToMarkdownLink<Models.Entities.Action>("Escape", Actions.Instances.Escape.ID)}. If you succeed, the creature or hazard imposing the condition on you (if applicable) takes force damage equal to your level." };
            yield return new TextBlock { Id = Guid.Parse("5f1c5de7-1dee-4575-9129-69e6c79db6b5"), Type = TextBlockType.Text, Text = $"~ Emotional Fervor: When you {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} from your spell slots, if the spell deals damage and doesn't have a duration, you gain a status bonus to that spell's damage equal to the spell's level. Spell: {ToMarkdownLink<Models.Entities.Spell>("draw ire", Spells.Instances.DrawIre.ID)}" };
            yield return new TextBlock { Id = Guid.Parse("310df961-e878-4039-a167-eee3d874d158"), Type = TextBlockType.Text, Text = $"~ Emotional Fallout: You become fatigued until you {ToMarkdownLink<Models.Entities.Feat>("Settle your Emotions", Feats.Instances.SettleEmotions.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("21134819-dbf6-4f68-8868-81c0a17bf532"), Type = TextBlockType.Text, Text = $"~ Focus Spell: {ToMarkdownLink<Models.Entities.Spell>("athletic rush", Spells.Instances.AthleticRush.ID)}" };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a505b39-9e5c-4c91-aa6e-74b54e050b8e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
