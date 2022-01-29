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
    public class AxialRecall : Template
    {
        public static readonly Guid ID = Guid.Parse("cab6bb4f-7ad6-42b4-8c47-b089e708fce1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Axial Recall",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c09ef587-0a58-48d4-8f34-b27c225438f6"), Type = TextBlockType.Text, Text = $"You have reconfigured the magical resonance of your core to attune to the planar energies of Axis. You can cast {ToMarkdownLink<Models.Entities.Spell>("plane shift", Spells.Instances.PlaneShift.ID)} twice per week as an arcane innate spell that can only target yourself; you can travel only to Axis or the Material Plane, and your body serves as the focus component." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("4ea452ff-927d-4eae-87c3-fc638722e163"), Traits.Instances.Automaton.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e34ec2a4-80ad-4661-a700-60a7cf08aa6d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
