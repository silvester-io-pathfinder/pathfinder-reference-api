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
    public class FormRetention : Template
    {
        public static readonly Guid ID = Guid.Parse("b63c8da1-07ea-4a36-a8da-65af5cfca7ca");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Form Retention",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4e60add5-bd8d-4ee3-ba14-ed9f80a445bd"), Type = TextBlockType.Text, Text = $"You have trained your mind and body to tolerate polymorph magic for longer periods of time, so long as you prepare for the change appropriately. When preparing a polymorph spell that lasts 1 minute and grants a battle form, you can prepare the spell in a slot 2 levels higher than normal. This doesn't grant any of the normal benefits of heightening a spell, but the spell lasts up to 10 minutes. For example, if you prepared {ToMarkdownLink<Models.Entities.Spell>("animal form", Spells.Instances.AnimalForm.ID)} in a 4th-level slot with Form Retention, you would cast a 2nd-level {ToMarkdownLink<Models.Entities.Spell>("animal form", Spells.Instances.AnimalForm.ID)} that lasts for up to 10 minutes. If the spell can be Dismissed, that doesn't change." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Wizard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("47e2d303-843c-4c0c-9dd1-dc8bd4048dd4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
