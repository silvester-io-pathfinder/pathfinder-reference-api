using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagicalResilience : Template
    {
        public static readonly Guid ID = Guid.Parse("d0b67bc6-71a8-48ac-bd3f-7f0d952f3a58");

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
            yield return new TextBlock { Id = Guid.Parse("5f01e5e6-07bc-45a6-8df4-d546ffe71af3"), Type = TextBlockType.Text, Text = "You gain a +2 status bonus to saving throws and AC against spells. If you’re 5th level or higher, you can cast (spell: dispel magic) once as an innate spell. The spell level is equal to 1 lower than half your level rounded up (2nd level if you’re 5th or 6th level, and so on)." };
            yield return new TextBlock { Id = Guid.Parse("cb1a7ca7-152c-495a-a6e4-db56b4c8a22a"), Type = TextBlockType.Text, Text = "__Corruption Flaw__ You take a –1 penalty to saving throws and AC against spells." };
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
                Id = Guid.Parse("c0bd73cb-b896-4ae7-807a-4a05cde1daf7"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
