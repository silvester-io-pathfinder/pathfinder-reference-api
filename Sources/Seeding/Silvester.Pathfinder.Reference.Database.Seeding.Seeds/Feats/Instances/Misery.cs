using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Misery : Template
    {
        public static readonly Guid ID = Guid.Parse("cbaa20ed-5465-48db-9bf6-ad0700e4395a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Misery",
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
            yield return new TextBlock { Id = Guid.Parse("9a789a5f-55ab-4bbf-8267-b96a46c6481f"), Type = TextBlockType.Text, Text = $"To suffer is to know you're alive; to make your enemies suffer as greatly as you have eases your suffering." };
            yield return new TextBlock { Id = Guid.Parse("b40a074e-389b-422f-80e1-659fc8b0c189"), Type = TextBlockType.Text, Text = $"~ Catharsis Trigger: You gain persistent damage from a foe." };
            yield return new TextBlock { Id = Guid.Parse("f634808e-ff01-4303-969d-60c3a903f0ef"), Type = TextBlockType.Text, Text = $"~ Catharsis Activation: You gain a number of temporary Hit Points equal to your level. They last for 1 minute." };
            yield return new TextBlock { Id = Guid.Parse("bae35c91-0f96-430f-abc3-32ce09263cf4"), Type = TextBlockType.Text, Text = $"~ Emotional Fervor: You can choose not to attempt a flat check to end persistent damage you're taking. When you cast a damaging spell, you can choose one creature that failed its save or that you hit with your spell attack roll. That target takes persistent damage of the same type the spell dealt, of an amount equal to the highest amount of persistent damage you currently have. You can't choose a creature that's already taking persistent damage. Spell: {ToMarkdownLink<Models.Entities.Spell>("phantom pain", Spells.Instances.PhantomPain.ID)}" };
            yield return new TextBlock { Id = Guid.Parse("2da27367-e6e8-4a06-8f22-df1da1eadb6d"), Type = TextBlockType.Text, Text = $"~ Emotional Fallout: You take an untyped penalty to any damage you would deal with any spell you cast until you {ToMarkdownLink<Models.Entities.Feat>("Settle your Emotions", Feats.Instances.SettleEmotions.ID)}. The penalty is –1 per spell level." };
            yield return new TextBlock { Id = Guid.Parse("d8b3242e-935e-4cb5-b8de-6fa72dd12ff9"), Type = TextBlockType.Text, Text = $"~ Focus Spell: {ToMarkdownLink<Models.Entities.Spell>("savor the sting", Spells.Instances.SavorTheSting.ID)}" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("71cfe460-3f08-46d3-85ab-2cd7d2b28ab8"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
