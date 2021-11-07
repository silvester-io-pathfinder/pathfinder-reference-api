using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElvenLore : Template
    {
        public static readonly Guid ID = Guid.Parse("216af5e3-a9e4-4eea-ae52-7ef54dc94cc1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elven Lore",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7f313603-d7cd-40bf-a303-7dd0b291a643"), Type = TextBlockType.Text, Text = "You’ve studied in traditional elven arts, learning about arcane magic and the world around you. You gain the trained proficiency rank in Arcana and Nature. If you would automatically become trained in one of those skills (from your background or class, for example), you instead become trained in a skill of your choice. You also become trained in Elven Lore." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("51564d47-f676-4e63-a25f-12dec14537a6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
