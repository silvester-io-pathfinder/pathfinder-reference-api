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
    public class EnergyAblation : Template
    {
        public static readonly Guid ID = Guid.Parse("1cc3e686-1295-4184-a404-7c6efcb48301");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Energy Ablation",
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
            yield return new TextBlock { Id = Guid.Parse("20149fd9-c908-4517-9729-14a4778efab8"), Type = TextBlockType.Text, Text = $"When you cast energy spells, you retain some of that energy as a protective barrier. If your next action is to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} that deals energy damage, whether or not it successfully deals damage, you gain resistance to that type of energy equal to the spell's level (minimum 1) until the end of your next turn. If the spell deals more than one type of energy damage, choose one and gain resistance to that type." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("ac0ebbb8-1f1b-4cc2-8e03-22c07b551129"), Traits.Instances.Metamagic.ID);
            builder.Add(Guid.Parse("68babdd2-db00-4e05-a2da-8f46cf3633b6"), Traits.Instances.Wizard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5990db8a-9721-4066-8fbd-b07f2ac33c21"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
