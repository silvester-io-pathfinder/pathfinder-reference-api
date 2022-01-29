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
    public class UnusualComposition : Template
    {
        public static readonly Guid ID = Guid.Parse("8b85457d-c0c8-4778-bbb8-d8c4da6cd2e5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unusual Composition",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d9502e28-a013-4250-822b-59a87726424e"), Type = TextBlockType.Text, Text = $"You can translate the emotion and power of a composition to other mediums. If your next action is to cast a {ToMarkdownLink<Models.Entities.Trait>("composition", Traits.Instances.Composition.ID)} spell, you can use a different kind of performance than usual for the composition to change any of its somatic components to verbal components or vice versa. As usual for {ToMarkdownLink<Models.Entities.Trait>("composition", Traits.Instances.Composition.ID)} spells, this changes whether the composition is {ToMarkdownLink<Models.Entities.Trait>("auditory", Traits.Instances.Auditory.ID)} or {ToMarkdownLink<Models.Entities.Trait>("visual", Traits.Instances.Visual.ID)}." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("58452022-273a-4495-a481-2f0f26139267"), Muses.Instances.Polymath.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("805a7ba4-10d4-4f51-b360-eff31fbff140"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("34d11409-0e11-498d-8f18-db1debe30ab8"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("ffe98fd5-26af-472c-98f8-e7924fd29a96"), Traits.Instances.Manipulate.ID);
            builder.Add(Guid.Parse("2a8e80fe-6a0e-4dd9-8ae7-eb50c4aebd67"), Traits.Instances.Metamagic.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("485dc13a-f740-4874-af6e-aea23c1576a9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
