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
    public class StealSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("f21561f9-ef86-4bdb-8410-be8b58ad316d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Steal Spell",
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
            yield return new TextBlock { Id = Guid.Parse("701be6d7-9ee8-4901-a685-9c764260197f"), Type = TextBlockType.Text, Text = $"When you use {ToMarkdownLink<Models.Entities.Feat>("Legendary Thief", Feats.Instances.LegendaryThief.ID)} to steal the impossible, you can steal a prepared spell or spontaneous spell from a foe. The spell is randomly selected from the highest-level spells the foe knows that have a target or area, to a maximum of 8th-level spells; the target loses the appropriate spell slot as if they had cast it themself. You can {ToMarkdownLink<Models.Entities.Rule>("Cast the Spell", Rules.Instances.CastASpell.ID)} once within the next 1d4 rounds, after which the fleeting magic fades; this otherwise works the same as casting a {ToMarkdownLink<Models.Entities.Feat>("Loaner Spell", Feats.Instances.LoanerSpell.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3790c31a-990e-4be6-ae4f-47f71edc87ed"), Feats.Instances.LegendaryThief.ID);
            builder.HaveSpecificFeat(Guid.Parse("6350b3dc-7a71-44f4-ac1e-ecd8f94e88c5"), Feats.Instances.LoanerSpell.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("e1ceaf96-f218-40a8-91f7-ae1465af02fe"), Traits.Instances.Magical.ID);
            builder.Add(Guid.Parse("4f746dd7-9ae4-43ee-b47d-9ef22979d751"), Traits.Instances.Rogue.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6a2e5ae7-bd71-4c78-a42f-d48235b822ee"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
