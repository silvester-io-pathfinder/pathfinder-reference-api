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
    public class DiverseMystery : Template
    {
        public static readonly Guid ID = Guid.Parse("e2d85c85-4dc7-4374-9397-b399e88f5a0f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Diverse Mystery",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f41e07f7-821d-462f-baae-e7e1810b10c4"), Type = TextBlockType.Text, Text = $"You have broadened your understanding of the divine and can tap into the wonders of a different mystery. Select one revelation spell from a mystery other than your own. You can choose only an initial revelation spell or an advanced revelation spell." };
            yield return new TextBlock { Id = Guid.Parse("d6d2c8e0-4024-46f5-a77d-04f7e116e90f"), Type = TextBlockType.Text, Text = $"When you cast this revelation spell, you gain the effects of the minor curse from that mystery in addition to the normal curse effects you gain from casting a revelation spell. This additional minor curse effect remains until your next daily preparations. Any ability that lets you cast a revelation spell without increasing the severity of your curse also prevents you from gaining this additional curse effect." };
            yield return new TextBlock { Id = Guid.Parse("01e015a1-573b-44c4-9cb1-4b6b1a444376"), Type = TextBlockType.Text, Text = $"You can't cast your chosen revelation spell if any of the following conditions are true: its mystery's curse effects directly conflict with or negate the effects of your own mystery's curse, the curse would have no effect on you (for example, removing an ability from your original mystery that you lack), or either of these criteria would be met once you finish {ToMarkdownLink<Models.Entities.Rule>("Casting the Spell", Rules.Instances.CastASpell.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("bc2e15c1-5f4c-4693-8722-2b384150817d"), Feats.Instances.AdvancedRevelation.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Oracle.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2a71d79c-6363-45f2-b7dc-ee2d8e59c5e4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
