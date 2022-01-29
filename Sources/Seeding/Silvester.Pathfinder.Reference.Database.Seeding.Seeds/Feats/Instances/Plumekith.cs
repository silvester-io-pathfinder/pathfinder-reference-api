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
    public class Plumekith : Template
    {
        public static readonly Guid ID = Guid.Parse("f66a5270-f315-4f58-9f6d-2618df52180e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Plumekith",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c3a01e1b-1868-4edf-9704-ced35b221d7e"), Type = TextBlockType.Text, Text = $"Your blood soars with the power of the magnificent garuda, proud and stoic avian warriors. You only take half the normal damage from falling and gain a +2 circumstance bonus to saving throws against effects with the {ToMarkdownLink<Models.Entities.Trait>("air", Traits.Instances.Air.ID)} trait." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Aasimar.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Lineage.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("175f9893-04b5-4900-80e2-8229a9dd69de"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
