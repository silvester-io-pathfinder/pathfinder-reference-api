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
    public class PlantShape : Template
    {
        public static readonly Guid ID = Guid.Parse("9e27abb8-5c97-4a34-a591-abfbab2fc3e0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Plant Shape",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d0da633c-124d-4393-9b33-8da3ad0ba122"), Type = TextBlockType.Text, Text = $"You can take the form of a plant creature. Add the forms listed in {ToMarkdownLink<Models.Entities.Spell>("plant form", Spells.Instances.PlantForm.ID)} to your {ToMarkdownLink<Models.Entities.Spell>("wild shape", Spells.Instances.WildShape.ID)} list; if you don't have {ToMarkdownLink<Models.Entities.Spell>("wild shape", Spells.Instances.WildShape.ID)}, you can instead cast {ToMarkdownLink<Models.Entities.Spell>("plant form", Spells.Instances.PlantForm.ID)} once per day, heightened to the same level as your highest druid spell slot. Whenever you're polymorphed into another form using {ToMarkdownLink<Models.Entities.Spell>("wild shape", Spells.Instances.WildShape.ID)}, you gain resistance 5 to poison." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("29f14442-b72f-4313-bae3-7f50166b88cf"), or => 
            {
                or.HaveSpecificDruidicOrder(Guid.Parse("8b8f2dcb-78d4-4ab1-b7e4-27e9c38a14e8"), DruidicOrders.Instances.Leaf.ID);
                or.HaveSpecificDruidicOrder(Guid.Parse("19e204d4-8a3f-4ac9-9aa5-42df804c75e0"), DruidicOrders.Instances.Wild.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("525a26f4-f3ea-467a-8e30-33caec8013a1"), Traits.Instances.Druid.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a4ec045e-c614-4fd6-ab5c-ac5ba0530f0e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
