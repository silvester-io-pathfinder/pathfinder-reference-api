using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DruidDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("57407801-927a-4d0a-9945-c457165b435c");

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
            yield return new TextBlock { Id = Guid.Parse("41d33513-5733-4bb3-b974-d565368a048f"), Type = TextBlockType.Text, Text = "You cast spells like a druid. You gain access to the (activity: Cast a Spell) activity. You can prepare two common cantrips each day from the primal spell list in this book or any other cantrips you learn or discover. You’re trained in spell attack rolls and spell DCs for primal spells. Your key spellcasting ability for druid archetype spells is Wisdom, and they are primal druid spells." };
            yield return new TextBlock { Id = Guid.Parse("9a4684ed-e04c-4777-9608-ae7119a75e75"), Type = TextBlockType.Text, Text = "You learn the Druidic language, and you are bound by the druid’s anathema." };
            yield return new TextBlock { Id = Guid.Parse("dbe551fd-c105-4df4-a63d-69d275981f87"), Type = TextBlockType.Text, Text = "Choose an order as you would if you were a druid. You become a member of that order and are bound by its anathema, allowing you to take the order’s feats. You become trained in Nature and your order’s associated skill; for each of these skills in which you were already trained, you become trained in a skill of your choice. You don’t gain any other abilities from your choice of order." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("7887ba32-76af-4f4f-accc-8dc70e3ed857"), requiredStatValue: 14, Stats.Instances.Wisdom.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c59f2ac1-3073-438e-87b5-532b6fc89577"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
