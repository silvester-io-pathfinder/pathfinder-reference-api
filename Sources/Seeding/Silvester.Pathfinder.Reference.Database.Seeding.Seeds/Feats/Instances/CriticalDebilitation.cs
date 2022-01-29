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
    public class CriticalDebilitation : Template
    {
        public static readonly Guid ID = Guid.Parse("a627ee44-2404-41c3-b9ad-89f90e97910c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Critical Debilitation",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("48005b6f-52c3-4066-b3bb-71d2d556f9c2"), Type = TextBlockType.Text, Text = $"Your debilitations are especially effective on your most powerful attacks. Whenever you critically succeed at an attack roll against an enemy and use {ToMarkdownLink<Models.Entities.Feat>("Debilitating Strike", Feats.Instances.DebilitatingStrike.ID)}, add the following debilitation to the list you can choose from." };
            yield return new TextBlock { Id = Guid.Parse("99db8028-559e-4296-9720-db47fd9cb71d"), Type = TextBlockType.Enumeration, Text = $" Debilitation: The target attempts a Fortitude save against your class DC with the following effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b834a980-e505-49ba-a4b9-e6dfd037b9c5"), Feats.Instances.DebilitatingStrike.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("87d5394d-c84d-4410-ad26-c2676e19eb51"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is slowed 1 until the end of your next turn.",
                Failure = "The target is slowed 2 until the end of your next turn.",
                CriticalFailure = "The target is paralyzed until the end of your next turn.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab72a422-2006-40fd-a8c2-f022efbb7aaf"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
