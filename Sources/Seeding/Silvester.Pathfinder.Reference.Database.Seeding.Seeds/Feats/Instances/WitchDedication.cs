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
    public class WitchDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("9c692a58-89f5-4651-af8c-2470d1608b08");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Witch Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the witch archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9d700e80-4097-4cc3-9a38-62a9fdb322ef"), Type = TextBlockType.Text, Text = $"You cast spells like a witch. Choose a patron; you gain a familiar with two common cantrips of your choice from your chosen patron's tradition, but aside from the tradition, you don't gain any other effects the patron would usually grant. Your familiar has one less familiar ability than normal. You gain the {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} activity. You can prepare one cantrip each day from your familiar. You're trained in spell attack rolls and spell DCs from your patron's tradition. Your key spellcasting ability for witch archetype spells is Intelligence, and they are witch spells of your patron's tradition. You become trained in the skill associated with the patron's tradition; if you were already trained in it, you instead become trained in a skill of your choice." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("7a48a96d-e893-4387-867b-4665555a5131"), requiredStatValue: 14, Stats.Instances.Intelligence.ID);
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
                Id = Guid.Parse("46c71e42-76b3-4355-983c-8c3b2a42cb64"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
