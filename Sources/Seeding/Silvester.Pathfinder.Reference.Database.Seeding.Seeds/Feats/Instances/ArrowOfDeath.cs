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
    public class ArrowOfDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("9bfffb06-fa98-44aa-a046-43d1885e14ee");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arrow of Death",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2e34c533-8030-4a6c-8ff3-9041d403c772"), Type = TextBlockType.Text, Text = $"You modify an arrow or bolt to bring death to your target in a single potent hit. Make a bow {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. On a hit, you deal an additional 10d10 precision damage. On a critical hit, the target must also succeed at a Fortitude saving throw against your class DC or spell DC, whichever is higher, or be immediately slain; this save has the {ToMarkdownLink<Models.Entities.Trait>("death", Traits.Instances.Death.ID)} and {ToMarkdownLink<Models.Entities.Trait>("incapacitation", Traits.Instances.Incapacitation.ID)} traits." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("73013d14-8c86-4002-9d06-cac1e28b688a"), Feats.Instances.EldritchArcherDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("501a888f-c4be-42dd-b1f5-22d8bbb55880"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
