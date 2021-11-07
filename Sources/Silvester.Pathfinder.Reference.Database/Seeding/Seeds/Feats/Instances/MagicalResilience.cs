using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagicalResilience : Template
    {
        public static readonly Guid ID = Guid.Parse("2bc43e21-c5dc-44ee-8dc6-ec8dc8dabe85");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magical Resilience",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d649784e-d204-4cc7-85f4-c1e19e3c56a9"), Type = TextBlockType.Text, Text = "You gain a +2 status bonus to saving throws and AC against spells. If you’re 5th level or higher, you can cast (spell: dispel magic) once as an innate spell. The spell level is equal to 1 lower than half your level rounded up (2nd level if you’re 5th or 6th level, and so on)." };
            yield return new TextBlock { Id = Guid.Parse("4dccdf53-a67f-4cec-9d6d-0c667a04a6c4"), Type = TextBlockType.Text, Text = "__Corruption Flaw__ You take a –1 penalty to saving throws and AC against spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("39c472c4-fd90-4c0d-bc05-859a4e49a0f1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
