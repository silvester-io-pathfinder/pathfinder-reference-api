using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnleashFocusedIntent : Template
    {
        public static readonly Guid ID = Guid.Parse("623e6389-a304-48f2-ac79-2d8e8f89fb0a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unleash Focused Intent",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b06663a6-3401-473b-872f-9722176dfb9f"), Type = TextBlockType.Text, Text = $"After some time of acclimating to a stressful situation, your psychic magic flares to greater destructive power." };
            yield return new TextBlock { Id = Guid.Parse("b73a65eb-b679-4f01-b1ed-3c6be06a8adc"), Type = TextBlockType.Text, Text = $"~ Benefit: When you {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} from your spell slots while you have Unleashed Focused Intent, you gain a status bonus to that spell's damage equal to double the spell's level as long as spell deals damage and doesn't have a duration." };
            yield return new TextBlock { Id = Guid.Parse("82b4d858-f557-4480-acbb-6599c7212fa6"), Type = TextBlockType.Text, Text = $"~ Drawback: The focus on offense comes at the expense of your defensive instincts. You take a –2 penalty to AC while you've Unleashed Focused Intent." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b878c60c-d05b-46df-982d-c373ce249707"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
