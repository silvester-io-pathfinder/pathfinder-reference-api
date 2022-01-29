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
    public class ArcaneCommunication : Template
    {
        public static readonly Guid ID = Guid.Parse("a9729bd2-d6de-460b-8b86-0faafa3da70c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Communication",
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
            yield return new TextBlock { Id = Guid.Parse("1ce81e5e-40e2-4764-b7cc-0b6bb29ddc50"), Type = TextBlockType.Text, Text = $"You can deliver silent messages. You gain touch telepathy, allowing you to communicate silently and mentally with any creature you're touching, as long as you share a language." };
            yield return new TextBlock { Id = Guid.Parse("b0e35cee-6c69-4ecd-a672-d973578c94dc"), Type = TextBlockType.Text, Text = $"----" };
            yield return new TextBlock { Id = Guid.Parse("0b0f6b4e-0918-43bd-976f-091947e0cce8"), Type = TextBlockType.Text, Text = $"~ Enhancement: You can send your messages even further. Your telepathy gains a range of 10 feet, but you still have to share a language with your target." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("9ac3d72b-6c3b-4976-b4ef-07cd0e077db1"), Traits.Instances.Automaton.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("77a0c3bf-4d6f-48b5-884f-d6ec35db746d"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
