using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MonsterWarden : Template
    {
        public static readonly Guid ID = Guid.Parse("6078adba-0676-4cd7-b709-afcae4bb959a");

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
            yield return new TextBlock { Id = Guid.Parse("9bf9dbd3-7bb7-4ff1-bad4-6517f79c0619"), Type = TextBlockType.Text, Text = $"You understand how to defend yourself and others against your prey. When you grant bonuses from {ToMarkdownLink<Models.Entities.Feat>("Monster Hunter", Feats.Instances.MonsterHunter.ID)}, you and your allies also each gain a +1 circumstance bonus to your next saving throw against that particular creature and to your AC against that creature's next attack against you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c25c6994-f910-4324-ab30-fee9fc31d567"), Feats.Instances.MonsterHunter.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("94e1e84d-e126-45f5-94b4-725728776343"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
