using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WizardDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("64cfb296-05b5-4f18-a427-8d79e1102dfb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wizard Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the wizard archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4714278c-2a2a-4a8b-9bff-ca5805d73ef7"), Type = TextBlockType.Text, Text = "You cast spells like a wizard, gaining a (item: spellbook) with four common arcane cantrips of your choice. You gain the (activity: Cast a Spell) activity. You can prepare two cantrips each day from your (item: spellbook). You’re trained in arcane spell attack rolls and spell DCs. Your key spellcasting ability for wizard archetype spells is Intelligence, and they are arcane wizard spells. You become trained in Arcana; if you were already trained in Arcana, you instead become trained in a skill of your choice." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("19000b14-c565-4fb1-8f54-cc56d251bfd8"), requiredStatValue: 14, Stats.Instances.Intelligence.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8b236351-211b-47d2-b406-cdb662ebe7ae"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
