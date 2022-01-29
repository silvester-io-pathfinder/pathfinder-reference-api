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
    public class CrossTheThreshold : Template
    {
        public static readonly Guid ID = Guid.Parse("7797c097-c981-4708-84e6-c08998f60b75");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cross the Threshold",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c34be944-5b15-4bdf-a8d9-9bbb0f20c127"), Type = TextBlockType.Text, Text = $"You can cast {ToMarkdownLink<Models.Entities.Spell>("ethereal jaunt", Spells.Instances.EtherealJaunt.ID)} as an occult innate spell once per day. You don't need to {ToMarkdownLink<Models.Entities.Action>("Sustain the Spell", Actions.Instances.SustainASpell.ID)}; instead, it lasts for 10 minutes or until you choose to return to your material form as a free action." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("61f17ee2-3201-4a97-90ab-b0474407eda8"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
