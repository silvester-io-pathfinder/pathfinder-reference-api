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
    public class DruidDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("45929b76-d5a8-4202-9645-37f233aacb50");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Druid Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the druid archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c5629a45-6779-4b1b-b030-ba6699825c21"), Type = TextBlockType.Text, Text = $"You cast spells like a druid. You gain access to the {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} activity. You can prepare two common cantrips each day from the primal spell list in this book or any other cantrips you learn or discover. You're trained in spell attack rolls and spell DCs for primal spells. Your key spellcasting ability for druid archetype spells is Wisdom, and they are primal druid spells." };
            yield return new TextBlock { Id = Guid.Parse("58a48b6e-574d-416b-ad0e-68511631b74f"), Type = TextBlockType.Text, Text = $"You learn the Druidic language, and you are bound by the druid's anathema." };
            yield return new TextBlock { Id = Guid.Parse("403da480-04f5-4c3e-b3e5-cab1600de768"), Type = TextBlockType.Text, Text = $"Choose an order as you would if you were a druid. You become a member of that order and are bound by its anathema, allowing you to take the order's feats. You become trained in Nature and your order's associated skill; for each of these skills in which you were already trained, you become trained in a skill of your choice. You don't gain any other abilities from your choice of order." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("73d29932-17f9-40f3-b043-fd5ab6d36d1a"), requiredStatValue: 14, Stats.Instances.Wisdom.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Dedication.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Multiclass.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b00760d9-0f94-4ab6-867e-b460fe49247f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
