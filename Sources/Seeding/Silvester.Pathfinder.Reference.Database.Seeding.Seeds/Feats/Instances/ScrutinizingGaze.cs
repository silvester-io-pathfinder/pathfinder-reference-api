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
    public class ScrutinizingGaze : Template
    {
        public static readonly Guid ID = Guid.Parse("6635fdaf-ee6c-4d6f-94a5-0f05d9f02feb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scrutinizing Gaze",
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
            yield return new TextBlock { Id = Guid.Parse("259941cb-abd8-49cc-be61-3f94046f0350"), Type = TextBlockType.Text, Text = $"~ Access: You are from Dongun Hold or Alkenstar." };
            yield return new TextBlock { Id = Guid.Parse("cf428e4f-d2c8-490f-912d-7db8f7661717"), Type = TextBlockType.Text, Text = $"Your family's traditions of defending against Geb's undead have granted you a sixth sense for detecting spirits, haunts, and other restless dead, no matter their form or the strength of their presence. You gain a +2 circumstance bonus to Perception checks to {ToMarkdownLink<Models.Entities.Action>("Sense Motive", Actions.Instances.SenseMotive.ID)} when trying to determine if a creature is possessed or under the influence of an effect that would make them controlled, a +2 circumstance bonus to Perception checks made to see through disguises worn by undead, and a +2 circumstance bonus when using the {ToMarkdownLink<Models.Entities.Action>("Seek", Actions.Instances.Seek.ID)} action to find hidden or undetected haunts or undead within 30 feet of you." };
            yield return new TextBlock { Id = Guid.Parse("1c0c906a-4e5b-436c-9688-bbe09b0cbc2c"), Type = TextBlockType.Text, Text = $"If you aren't using the {ToMarkdownLink<Models.Entities.Action>("Seek", Actions.Instances.Seek.ID)} action or searching, the GM automatically rolls a secret check for you to notice haunts or undead within 30 feet anyway. This check doesn't gain the usual +2 circumstance bonus, and instead takes a –2 circumstance penalty." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Dwarf.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b20a36ff-ee0b-468a-8d9b-42437eaaa572"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
