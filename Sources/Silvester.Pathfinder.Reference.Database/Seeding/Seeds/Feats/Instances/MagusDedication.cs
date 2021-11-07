using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagusDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("5602dfa9-165a-4a21-99a7-ce3d9247b4b1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magus Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the magus archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8c903e85-e267-468d-ae3f-10a1e38b6f52"), Type = TextBlockType.Text, Text = "You cast spells like a magus, gaining a (item: spellbook) with four common arcane cantrips of your choice. You gain the (action: Cast a Spell) activity. You can prepare two cantrips each day from your (item: spellbook). Each time you gain a spell slot of a new level from the magus archetype, add a spell of that level or lower to your (item: spellbook). You’re trained in arcane spell attack rolls and spell DCs. Your key spellcasting ability for magus archetype spells is Intelligence, and they are arcane magus spells. You become trained in Arcana; if you were already trained in Arcana, you instead become trained in a skill of your choice. You become trained in simple weapons." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("6cfff598-d622-412a-968f-ea0d4d51bca3"), or => 
            {
                or.HaveSpecificStat(Guid.Parse("0e61ea5d-4bc4-446e-aa5a-e0f869a9f60e"), requiredStatValue: 14, Stats.Instances.Strength.ID);
                or.HaveSpecificStat(Guid.Parse("da553c14-48b2-4d1b-8be4-a528035b2e51"), requiredStatValue: 14, Stats.Instances.Dexterity.ID);
            });
            builder.HaveSpecificStat(Guid.Parse("128cf003-02d1-47ad-9b2d-01c91ec99e3e"), requiredStatValue: 14, Stats.Instances.Intelligence.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de049670-07cf-4b29-93ab-45ce335e8fc3"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
