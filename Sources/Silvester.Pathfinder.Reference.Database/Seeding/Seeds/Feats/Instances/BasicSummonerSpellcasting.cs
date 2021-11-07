using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BasicSummonerSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("b26d3667-e9cc-4ecc-8e2f-faaae53d9373");

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
            yield return new TextBlock { Id = Guid.Parse("6368bdfe-b6af-4b12-a770-918b9f7248b5"), Type = TextBlockType.Text, Text = "You gain a 1st and 2nd-level spell slot. At 10th level, replace your 1st-level spell slot with a 3rd-level spell slot. You gain the (action: Cast a Spell) activity. Your key spellcasting ability for summoner archetype spells is Charisma, and they are summoner spells of your eidolon’s tradition. You become trained in spell attack rolls and spell DCs of that tradition. You gain a spell repertoire and two cantrips. Each time you gain a spell slot of a new level from the summoner archetype, add a spell of that level or lower to your repertoire. You can select one spell from your repertoire as a signature spell. Each time you lose spell slots of a particular level, remove those spells from your repertoire." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("844eeb48-04cf-4f19-ad27-4f3ae3741e28"), Feats.Instances.SummonerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e9831e2-6885-43a5-8a75-9f2ad0c08328"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
