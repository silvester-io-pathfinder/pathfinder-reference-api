using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MonsterWarden : Template
    {
        public static readonly Guid ID = Guid.Parse("02f12026-f9e2-4687-b4bb-a693061b1652");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Monster Warden",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("db85a718-5004-4299-87f8-ba9b53f824c8"), Type = TextBlockType.Text, Text = "You understand how to defend yourself and others against your prey. When you grant bonuses from (feat: Monster Hunter), you and your allies also each gain a +1 circumstance bonus to your next saving throw against that particular creature and to your AC against that creature’s next attack against you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("fb86f136-4453-4187-a75c-09f547552f78"), Feats.Instances.MonsterHunter.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba243851-c63a-4e55-bf42-fdc4a1d1aa7d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
