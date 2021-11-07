using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ThaumaturgesInvestiture : Template
    {
        public static readonly Guid ID = Guid.Parse("a9e7138d-1332-4478-a579-199c3b7a34cc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Thaumaturge's Investiture",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("782f8b40-39b2-468a-86c7-5cb96125ecbd"), Type = TextBlockType.Text, Text = "Using your knowledge of esoterica and implements, you can invest far more items than most. You gain the (feat: Incredible Investiture) skill feat, increasing your limit on invested items from 10 to 12. The limit increases to 14 if you have Charisma 18, 16 if you have Charisma 20, 18 if you have Charisma 22, and 20 if you have Charisma 24." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStat(Guid.Parse("9539263c-38e8-43ae-817b-6b1e596d327f"), requiredStatValue: 16, Stats.Instances.Charisma.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1c789fd5-2359-4d08-b98a-17f865d0c7c6"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
