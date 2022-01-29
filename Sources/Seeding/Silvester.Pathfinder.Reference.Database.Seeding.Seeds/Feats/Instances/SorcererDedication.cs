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
    public class SorcererDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("e2798d6b-8bda-4415-afd1-ca1b5b75df36");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sorcerer Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the sorcerer archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4941e6af-8081-4750-abc2-13bbaab6b73b"), Type = TextBlockType.Text, Text = $"Choose a bloodline. You become trained in the bloodline's two skills; for each of these skills in which you were already trained, you become trained in a skill of your choice." };
            yield return new TextBlock { Id = Guid.Parse("373997af-a015-4744-87d8-ebe8e6332e45"), Type = TextBlockType.Text, Text = $"You cast spells like a sorcerer. You gain access to the {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} activity. You gain a spell repertoire with two common cantrips from the spell list associated with your bloodline, from the spells granted by your bloodline, or any other cantrips of that tradition you learn or discover. You're trained in spell attack rolls and spell DCs for your tradition's spells. Your key spellcasting ability for sorcerer archetype spells is Charisma, and they are sorcerer spells of your bloodline's tradition. You don't gain any other abilities from your choice of bloodline." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("1971afd8-067e-4a7a-8e55-5a957efa923b"), requiredStatValue: 14, Stats.Instances.Charisma.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c7fd3963-4f75-404e-9782-5d0d7ff4d53e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
