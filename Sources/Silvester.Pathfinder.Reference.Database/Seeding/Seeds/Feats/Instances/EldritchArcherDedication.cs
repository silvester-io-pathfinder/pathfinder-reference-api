using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EldritchArcherDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("9306baf1-e15d-46cc-9bb0-bf076f535dbb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eldritch Archer Dedication",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the eldritch archer archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b5d55d1c-b06a-4812-a77b-5a18891aa398"), Type = TextBlockType.Text, Text = "You blend magic with your archery, leading to powerful results. If you don’t already cast spells from spell slots, you learn to cast spontaneous spells and gain the (activity: Cast a Spell) activity. You gain a spell repertoire with one cantrip of your choice, from a spell list of your choice. You choose this cantrip from the common spells on your chosen spell list or from other spells to which you have access on that list. This cantrip must require a spell attack roll. You’re trained in spell attack rolls and spell DCs for that tradition. Your key spellcasting ability for these spells is Charisma." };
            yield return new TextBlock { Id = Guid.Parse("39716042-e3a3-4fe1-b26d-0a353067546c"), Type = TextBlockType.Text, Text = "If you already cast spells from spell slots, you learn one additional cantrip from that tradition. If you’re a prepared caster, you can prepare this spell in addition to your usual cantrips per day; if you’re a spontaneous caster, you add this cantrip to your spell repertoire." };
            yield return new TextBlock { Id = Guid.Parse("b089bb62-68d4-4756-b0d0-df5c0d1cfa61"), Type = TextBlockType.Text, Text = "You also gain (feat: Eldritch Shot)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificWeaponGroupSpecificProficiency(Guid.Parse("9339652c-b8ef-47e2-87a5-34eae7fd54cf"), Proficiencies.Instances.Expert.ID, WeaponGroups.Instances.Bow.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ee5714c7-d70f-45db-a0a4-34a734e3ec4b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
