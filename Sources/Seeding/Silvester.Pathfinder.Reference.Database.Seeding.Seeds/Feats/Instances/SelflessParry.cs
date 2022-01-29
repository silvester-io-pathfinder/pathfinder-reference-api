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
    public class SelflessParry : Template
    {
        public static readonly Guid ID = Guid.Parse("edf6826f-c0c2-44fe-854d-add79ded03f0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Selfless Parry",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5a310572-3a8b-4123-b5cb-8d391af094ee"), Type = TextBlockType.Text, Text = $"You protect those near you with a flash of steel. When you're benefiting from {ToMarkdownLink<Models.Entities.Feat>("Dueling Parry", Feats.Instances.DuelingParry.ID)}, allies adjacent to you gain a +1 circumstance bonus to AC. If you have {ToMarkdownLink<Models.Entities.Feat>("Dueling Riposte", Feats.Instances.DuelingRiposte.ID)}, you can use it when an enemy within your reach critically fails a {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against an ally adjacent to you, not just against yourself." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cff65d7f-0e8b-4e22-8ed5-2f9b68cfbe98"), Feats.Instances.DuelingParry.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("8ebff4b5-9a2b-45c7-85e1-049f1f178951"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dda0351f-3525-4314-b3a1-3872020d59de"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
