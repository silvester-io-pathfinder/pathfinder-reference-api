using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SorcererDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("43f9dc0d-98fd-48b8-aa4c-f5e45b63ad6a");

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
            yield return new TextBlock { Id = Guid.Parse("281a5905-01da-441a-b46f-fbf45f305d65"), Type = TextBlockType.Text, Text = "Choose a bloodline. You become trained in the bloodline’s two skills; for each of these skills in which you were already trained, you become trained in a skill of your choice." };
            yield return new TextBlock { Id = Guid.Parse("2e447adb-1108-4351-a498-3090612c8922"), Type = TextBlockType.Text, Text = "You cast spells like a sorcerer. You gain access to the (activity: Cast a Spell) activity. You gain a spell repertoire with two common cantrips from the spell list associated with your bloodline, from the spells granted by your bloodline, or any other cantrips of that tradition you learn or discover. You’re trained in spell attack rolls and spell DCs for your tradition’s spells. Your key spellcasting ability for sorcerer archetype spells is Charisma, and they are sorcerer spells of your bloodline’s tradition. You don’t gain any other abilities from your choice of bloodline." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("2e0aa724-092b-4799-92ae-f3168b3251d5"), requiredStatValue: 14, Stats.Instances.Charisma.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("87eee5d5-12be-485a-9264-dfe442da9ce1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
