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
    public class ImpossibleRiposte : Template
    {
        public static readonly Guid ID = Guid.Parse("f5a3c42a-f5bc-4e64-9412-588ea1d31c16");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Impossible Riposte",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("08ccd4d6-6f7b-4129-9daf-905a9490db7f"), Type = TextBlockType.Text, Text = $"Your ripostes can deflect attacks back at their source. You can use {ToMarkdownLink<Models.Entities.Feat>("Opportune Riposte", Feats.Instances.OpportuneRiposte.ID)} with a trigger of “A foe outside of your reach critically fails an attack roll against you” in addition to its usual trigger. When you use {ToMarkdownLink<Models.Entities.Feat>("Opportune Riposte", Feats.Instances.OpportuneRiposte.ID)} with this new trigger against a ranged attack, your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} deflects some of the triggering effect back toward its source. Compare the result of your attack roll to the AC of the triggering foe. On a hit, you deal the normal amount of damage for your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, but the damage type changes to that of the triggering attack. For instance, if you used {ToMarkdownLink<Models.Entities.Feat>("Opportune Riposte", Feats.Instances.OpportuneRiposte.ID)} to deflect a {ToMarkdownLink<Models.Entities.Spell>("ray of frost", Spells.Instances.RayOfFrost.ID)}, your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} would deal cold damage instead of its normal damage type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("54cad998-223c-417e-ba31-7a153d279f4c"), Feats.Instances.OpportuneRiposte.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("9811e877-d424-4ce9-b400-c56262b827d5"), Traits.Instances.Swashbuckler.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b37dda80-8dc5-4f8c-b745-cd6ca538cba5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
