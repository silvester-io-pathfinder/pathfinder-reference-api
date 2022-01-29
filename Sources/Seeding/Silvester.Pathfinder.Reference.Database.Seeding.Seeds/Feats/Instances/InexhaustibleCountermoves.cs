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
    public class InexhaustibleCountermoves : Template
    {
        public static readonly Guid ID = Guid.Parse("eb60ef84-cceb-4328-bf1f-ee54e7f71f57");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Inexhaustible Countermoves",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("585ad20f-e3bf-4efb-92b4-5cd161fab665"), Type = TextBlockType.Text, Text = $"You can react whenever a foe leaves a gap in their defenses. At the start of each enemy's turn, you gain an extra reaction you can use only during that turn to perform an {ToMarkdownLink<Models.Entities.Feat>("Opportune Riposte", Feats.Instances.OpportuneRiposte.ID)}, or an {ToMarkdownLink<Models.Entities.Feat>("Attack of Opportunity", Feats.Instances.AttackOfOpportunity.ID)} if you have that reaction." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Swashbuckler.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("805edbae-05fa-4084-9630-64f308a7f1ff"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
