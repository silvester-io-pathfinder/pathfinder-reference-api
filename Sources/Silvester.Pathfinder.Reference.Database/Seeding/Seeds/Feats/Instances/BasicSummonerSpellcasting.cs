using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BasicSummonerSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("e7edfdf8-2042-4137-af08-d8779dedfb4b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Basic Summoner Spellcasting",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5b6ec758-e02b-44fe-a78f-121ba459b51e"), Type = TextBlockType.Text, Text = "You gain a 1st and 2nd-level spell slot. At 10th level, replace your 1st-level spell slot with a 3rd-level spell slot. You gain the (action: Cast a Spell) activity. Your key spellcasting ability for summoner archetype spells is Charisma, and they are summoner spells of your eidolon’s tradition. You become trained in spell attack rolls and spell DCs of that tradition. You gain a spell repertoire and two cantrips. Each time you gain a spell slot of a new level from the summoner archetype, add a spell of that level or lower to your repertoire. You can select one spell from your repertoire as a signature spell. Each time you lose spell slots of a particular level, remove those spells from your repertoire." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("50b16aae-cc8a-4ffc-bf85-781f321974d4"), Feats.Instances.SummonerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c926f8f-4569-4fd5-9cac-3bdc7279a024"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
