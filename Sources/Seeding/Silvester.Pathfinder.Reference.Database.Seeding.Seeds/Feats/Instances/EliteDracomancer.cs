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
    public class EliteDracomancer : Template
    {
        public static readonly Guid ID = Guid.Parse("c3d494d4-69f3-4a41-b7b5-69f977e24b5e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elite Dracomancer",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("88e81f6c-8726-46a6-88f6-26ca4f12e288"), Type = TextBlockType.Text, Text = $"Your magic rivals that of lesser dragons. Choose one 3rd-level spell and one 4th-level spell from those listed for a dragon spellcaster of your draconic exemplar's type (such as {ToMarkdownLink<Models.Entities.Spell>("paralyze", Spells.Instances.Paralyze.ID)} and {ToMarkdownLink<Models.Entities.Spell>("stinking cloud", Spells.Instances.StinkingCloud.ID)} for a black dragon exemplar). You can cast each of these spells once per day as arcane innate spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("33d5b7e2-621b-4f41-81a4-b7e7e8cce540"), Feats.Instances.Dracomancer.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Kobold.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("68381bea-665d-44a7-8f2e-0d0ac5643302"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
