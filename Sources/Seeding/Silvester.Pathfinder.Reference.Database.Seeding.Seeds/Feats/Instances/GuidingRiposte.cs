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
    public class GuidingRiposte : Template
    {
        public static readonly Guid ID = Guid.Parse("2fa8031a-2ee0-4f9b-b1c3-d9db79d0c23f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Guiding Riposte",
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
            yield return new TextBlock { Id = Guid.Parse("a2db200d-6987-4fc5-967f-6c5bd308b800"), Type = TextBlockType.Text, Text = $"By shifting your weight and angling your weapon, you guide your opponent to a more favorable position. When you use {ToMarkdownLink<Models.Entities.Feat>("Dueling Riposte", Feats.Instances.DuelingRiposte.ID)} to {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} and you hit, you can move the target up to 10 feet into a space in your reach. This follows the forced movement rules (page 475)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d7aeeff8-afef-4783-990b-7927560f70da"), Feats.Instances.DuelingRiposte.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2f392bd9-9aa2-4d82-a18d-b5690d5aeb52"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
