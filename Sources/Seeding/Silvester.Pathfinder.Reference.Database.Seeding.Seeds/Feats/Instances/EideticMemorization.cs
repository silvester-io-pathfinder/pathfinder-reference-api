using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EideticMemorization : Template
    {
        public static readonly Guid ID = Guid.Parse("89262af3-9ad7-4898-8ea2-f0d0ec499ba3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eidetic Memorization",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d8102e8a-7de6-4cbd-8516-4c11cd7484fc"), Type = TextBlockType.Text, Text = $"Pathfinders are often asked to study the intricacies of ancient history under less than ideal conditions, and you've trained your brain to make the most of your limited time. You quickly memorize an inscription, scroll, or other piece of writing you can clearly see whose length is equivalent to no more than one page. You can then accurately recreate this writing using a {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("writing kit", Items.AdventuringGears.Instances.WritingSet.ID)}, {ToMarkdownLink<Models.Items.Instances.AdventuringGear >("wax tablet", Items.AdventuringGears.Instances.WaxKeyBlank.ID)}, or other writing medium, once you have reached safety." };
            yield return new TextBlock { Id = Guid.Parse("a388821e-64d3-45a0-9809-a0a9327fec50"), Type = TextBlockType.Text, Text = $"You don't need to understand the writing or identify the language to reproduce it. Your memory lasts until the next time you make your daily preparations; if you have not written down or otherwise recreated what you saw by this point, your memory fades and any attempt to recreate what you saw is garbled and unintelligible. You can have only one piece of writing memorized at a time; any previous memorization fades the next time you use this ability." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d00dd800-d653-4efa-b9f8-d2a4ece1e46f"), Feats.Instances.PathfinderAgentDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a53b0bf5-325d-4bd2-b6eb-51b341b26b57"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
