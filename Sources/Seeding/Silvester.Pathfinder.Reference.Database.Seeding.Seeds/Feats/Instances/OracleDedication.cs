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
    public class OracleDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("18baaca3-b365-450e-bd69-b136113eca30");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Oracle Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the oracle archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("426a150b-3a9a-47fc-b42b-d004c3fe311d"), Type = TextBlockType.Text, Text = $"Choose a mystery (APG pg. 72). You become trained in Religion and the mystery's skill; if you were already trained, you become trained in a skill of your choice. You gain the mild, constant effects of the mystery's curse described in its first paragraph, but not other effects the mystery usually grants. You cast spells like an oracle and gain the {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} activity. You gain a spell repertoire with two cantrips, either common divine cantrips or other divine cantrips you learn or discover. You're trained in divine spell attack rolls and divine spell DCs. Your key spellcasting ability for oracle archetype spells is Charisma, and they are divine oracle spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("7a52e8f6-a41f-44c7-aec6-84aaecb18b12"), requiredStatValue: 14, Stats.Instances.Charisma.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("c214f67e-c58e-482c-b7af-8bd927c920c1"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("74223fb4-3ad5-46a9-8884-3c4498244156"), Traits.Instances.Dedication.ID);
            builder.Add(Guid.Parse("ed6c3689-6abb-4df2-9e75-3502a0b7c83d"), Traits.Instances.Multiclass.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2171f543-b081-4bec-9f4b-1cfea2168213"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
