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
    public class WebWeaver : Template
    {
        public static readonly Guid ID = Guid.Parse("3a232811-e1f8-4899-9e89-2badc0dd11a2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Web Weaver",
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
            yield return new TextBlock { Id = Guid.Parse("64791257-0620-49f1-80b4-21bc176abeba"), Type = TextBlockType.Text, Text = $"You can produce a soft silk to weave into useful items. You gain the {ToMarkdownLink<Models.Entities.Feat>("Specialty Crafting", Feats.Instances.SpecialtyCrafting.ID)} feat with a specialty in weaving. You can use your webbing to {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} simple, nonconsumable threaded items, such as clothing and rope, at zero cost as long as their base Price is 1 sp or less. These items have no resale value, and they naturally degrade after 24 hours without regular (if minor) maintenance. You can maintain up to 10 such items at a time; if you create a new one, your oldest creation breaks down from neglect. These temporary items take you only 1 day to {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} instead of 4. If you're an expert in Crafting, you can {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} these items in 1 hour; if you're a master, you can {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} them in 10 minutes; if you're legendary, you can {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} them in 1 minute." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Anadi.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa569919-2090-4b82-8f1f-f987316eae6d"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
