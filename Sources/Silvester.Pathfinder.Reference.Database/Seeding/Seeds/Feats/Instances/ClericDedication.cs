using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ClericDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("45e8657d-95f1-48ce-b346-116bbf451c02");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cleric Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the cleric archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("37509bbf-581f-419a-9a06-284264ff55ef"), Type = TextBlockType.Text, Text = "You cast spells like a cleric. You gain access to the (activity: Cast a Spell) activity. You can prepare two common cantrips each day from the divine spell list in this book or any other cantrips you learn or discover. You’re trained in spell attack rolls and spell DCs for divine spells. Your key spellcasting ability for cleric archetype spells is Wisdom, and they are divine cleric spells. Choose a deity as you would if you were a cleric. You become bound by that deity’s anathema. You become trained in Religion and your deity’s associated skill; for each of these skills in which you were already trained, you instead become trained in a skill of your choice. You don’t gain any other abilities from your choice of deity." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("a6d9eb0d-a474-42ed-a76c-abc84abc36d9"), requiredStatValue: 14, Stats.Instances.Wisdom.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("baf127a4-72ec-49bd-a8a0-d501375779fd"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
