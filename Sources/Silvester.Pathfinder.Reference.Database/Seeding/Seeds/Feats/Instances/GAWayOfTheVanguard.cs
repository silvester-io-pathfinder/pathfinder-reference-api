using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GAWayOfTheVanguard : Template
    {
        public static readonly Guid ID = Guid.Parse("fba298d7-3f13-435c-a12c-0075176a95cd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "GA - Way of the Vanguard",
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
            yield return new TextBlock { Id = Guid.Parse("bb6270f2-8c21-44e7-b6ef-da5a4b46e28e"), Type = TextBlockType.Text, Text = "You practice a style of shooting that seeks to ensure that your first shot is perfectly placed. You keep hidden or at a distance, staying out of the fray and bringing unseen death to your foes." };
            yield return new TextBlock { Id = Guid.Parse("2866d11f-f518-432a-b1cc-727c4ef595d0"), Type = TextBlockType.Text, Text = "~ Slinger&#39;s Reload: (feat: Clear a Path)" };
            yield return new TextBlock { Id = Guid.Parse("19a9297f-0064-4a5b-a87d-d058d9f174ca"), Type = TextBlockType.Text, Text = "~ Deeds: __Initial__ (feat: Living Fortification); __Advanced__ (feat: Spinning Crush); __Greater__ (feat: Siegebreaker)" };
            yield return new TextBlock { Id = Guid.Parse("e8f442cb-1489-4b64-aeb5-b8c36454f5cb"), Type = TextBlockType.Text, Text = "~ Way Skill: Athletics" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d980b7f-1070-45b9-b57b-05bed376b2c9"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
