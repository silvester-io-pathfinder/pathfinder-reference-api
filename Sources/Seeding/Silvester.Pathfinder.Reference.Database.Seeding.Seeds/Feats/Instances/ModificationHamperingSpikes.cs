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
    public class ModificationHamperingSpikes : Template
    {
        public static readonly Guid ID = Guid.Parse("c3f6e6b1-7317-4233-8267-82d50f9205a5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Hampering Spikes",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("94adcd48-2483-4162-90dd-4567f6c57cc1"), Type = TextBlockType.Enumeration, Text = $"*Melee Only**" };
            yield return new TextBlock { Id = Guid.Parse("9cb7098b-15dd-4d58-977f-e39e0177b606"), Type = TextBlockType.Text, Text = $"You've added long, snagging spikes to your weapon, which you can use to impede your foes' movement. Your innovation gains the {ToMarkdownLink<Models.Entities.Trait>("hampering", Traits.Instances.Hampering.ID)} and {ToMarkdownLink<Models.Entities.Trait>("versatile P", Traits.Instances.Versatile.ID)} traits." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("68cbb86f-c14b-4a5a-94f9-25b83c31c0e4"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
