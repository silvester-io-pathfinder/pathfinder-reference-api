using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WitchDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("aa948b3d-8ca2-42ce-844e-841ff9ce3679");

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
            yield return new TextBlock { Id = Guid.Parse("c6a1f567-45ac-4503-97d7-e85d48f88841"), Type = TextBlockType.Text, Text = "You cast spells like a witch. Choose a patron; you gain a familiar with two common cantrips of your choice from your chosen patron’s tradition, but aside from the tradition, you don’t gain any other effects the patron would usually grant. Your familiar has one less familiar ability than normal. You gain the (activity: Cast a Spell) activity. You can prepare one cantrip each day from your familiar. You’re trained in spell attack rolls and spell DCs from your patron’s tradition. Your key spellcasting ability for witch archetype spells is Intelligence, and they are witch spells of your patron’s tradition. You become trained in the skill associated with the patron’s tradition; if you were already trained in it, you instead become trained in a skill of your choice." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("a27e1e31-846b-41f5-8908-33e7315aea9c"), requiredStatValue: 14, Stats.Instances.Intelligence.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("68c60166-5521-4b05-9e9f-216289b3250b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
