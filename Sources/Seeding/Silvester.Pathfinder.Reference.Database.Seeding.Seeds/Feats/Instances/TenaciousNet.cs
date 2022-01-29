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
    public class TenaciousNet : Template
    {
        public static readonly Guid ID = Guid.Parse("c20c7fba-4631-4111-8076-fdc736cd75c8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tenacious Net",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("561350a6-e6db-4a28-a6f2-2c61581839bc"), Type = TextBlockType.Text, Text = $"Escaping your nets is no simple task. The Athletics DC to {ToMarkdownLink<Models.Entities.SkillAction>("Force Open", SkillActions.Instances.ForceOpen.ID)} or {ToMarkdownLink<Models.Entities.Action>("Escape", Actions.Instances.Escape.ID)} your nets increases from 16 to 18. After a creature you grabbed with a {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("net", Items.AdventuringGears.Instances.Net.ID)} {ToMarkdownLink<Models.Entities.Action>("Escapes", Actions.Instances.Escape.ID)} or {ToMarkdownLink<Models.Entities.SkillAction>("Forces Open", SkillActions.Instances.ForceOpen.ID)} the net, stray strands of the net cling to the creature, causing them to remain flat-footed until the beginning of their next turn." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("a9909b43-3f70-4aa2-ba24-210f6e7a9ee0"), Traits.Instances.Grippli.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e1d90098-f49c-4562-9438-119f7cbae98d"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
