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
    public class RatForm : Template
    {
        public static readonly Guid ID = Guid.Parse("1920889d-c5fc-499b-9fee-dca2761d13a7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rat Form",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c118dba9-0b67-4a69-aeb4-418eb64f4323"), Type = TextBlockType.Text, Text = $"You can transform into an innocuous-looking rat to scout an area or slip through tight spaces. You gain the effects of a 1st-level {ToMarkdownLink<Models.Entities.Spell>("pest form", Spells.Instances.PestForm.ID)} spell, except that you must assume the battle form of a Tiny rat." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("eaa7288b-f39e-423e-a491-1cca0550f0b0"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("8e9b53cb-7854-4764-b491-2e6179617707"), Traits.Instances.Polymorph.ID);
            builder.Add(Guid.Parse("d3f38032-5198-4e29-a3c5-1efc4ebdd613"), Traits.Instances.Primal.ID);
            builder.Add(Guid.Parse("532e45df-aafd-4c32-aa3d-dca05a9a685f"), Traits.Instances.Ratfolk.ID);
            builder.Add(Guid.Parse("845815dd-c70e-44f3-ae19-1545d8b7ccb9"), Traits.Instances.Transmutation.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ca28a4d9-0af8-486b-ac51-886defb05169"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
