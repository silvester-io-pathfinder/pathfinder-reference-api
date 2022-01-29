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
    public class NonlethalSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("b32ddc4d-231c-478e-9c7a-c33f4fab9153");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nonlethal Spell",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c0b564de-c35e-4b5b-95dc-55a09e77b84a"), Type = TextBlockType.Text, Text = $"You can alter offensive spells to be less deadly. If your next action is to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} that deals damage and doesn't have the {ToMarkdownLink<Models.Entities.Trait>("death", Traits.Instances.Death.ID)} or {ToMarkdownLink<Models.Entities.Trait>("negative", Traits.Instances.Negative.ID)} trait, that spell gains the {ToMarkdownLink<Models.Entities.Trait>("nonlethal", Traits.Instances.Nonlethal.ID)} trait." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("798bffa1-9203-4bd4-a021-331158fd131b"), Traits.Instances.Manipulate.ID);
            builder.Add(Guid.Parse("5b2a783b-f875-4bde-9e61-9df8c4120100"), Traits.Instances.Metamagic.ID);
            builder.Add(Guid.Parse("8631e4b0-afc7-42b5-8bee-58953558ad25"), Traits.Instances.Wizard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6bcf11b2-9733-45dd-aeb9-58be5f189ecb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
