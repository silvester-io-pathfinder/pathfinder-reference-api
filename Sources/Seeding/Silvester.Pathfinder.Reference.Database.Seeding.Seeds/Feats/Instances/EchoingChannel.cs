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
    public class EchoingChannel : Template
    {
        public static readonly Guid ID = Guid.Parse("30d1d83f-dc5b-447f-a5d3-908a19be8189");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Echoing Channel",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3ada76d0-f927-4dc1-9028-fa61a355ec61"), Type = TextBlockType.Text, Text = $"When you pull forth positive or negative energy, you also create a smaller pocket of that energy. If the next action you use is to cast a 2-action {ToMarkdownLink<Models.Entities.Spell>("harm", Spells.Instances.Harm.ID)} or {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)} to heal or damage a single creature, choose one additional creature adjacent to either you or the target. Target that creature with a 1-action version of the same spell. This spell is the same level as the 2-action {ToMarkdownLink<Models.Entities.Spell>("harm", Spells.Instances.Harm.ID)} or {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)} you cast and doesn't cost another spell slot." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("d9ed7e54-cbc2-4eb0-9e53-1c2631e2f443"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("7e0993ae-ab41-4b5c-9770-7478982166a1"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("4ffe9e9d-d8cf-41de-93a0-f5f3a0b21201"), Traits.Instances.Metamagic.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56dce915-b6b4-4468-8554-339711831986"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
