using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GAWayOfTheSniper : Template
    {
        public static readonly Guid ID = Guid.Parse("fc3f7c17-7cbc-43ce-b009-52ec6bdc9811");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "GA - Way of the Sniper",
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
            yield return new TextBlock { Id = Guid.Parse("86711aa7-3e3a-4107-ad32-4bdbde237f81"), Type = TextBlockType.Text, Text = "You practice a style of shooting that seeks to ensure that your first shot is perfectly placed. You keep hidden or at a distance, staying out of the fray and bringing unseen death to your foes." };
            yield return new TextBlock { Id = Guid.Parse("8c2e8094-b7d3-451e-857e-e01cb004670e"), Type = TextBlockType.Text, Text = "~ Slinger&#39;s Reload: (feat: Covered Reload)" };
            yield return new TextBlock { Id = Guid.Parse("4d4d07c2-1e0c-4b50-8f90-6545747c94da"), Type = TextBlockType.Text, Text = "~ Deeds: __Initial__ (feat: One Shot, One Kill); __Advanced__ (feat: Vital Shot); __Greater__ (feat: Ghost Shot)" };
            yield return new TextBlock { Id = Guid.Parse("d9b0ab9b-37e9-4b47-9a0b-9ee2b74b2b74"), Type = TextBlockType.Text, Text = "~ Way Skill: Stealth" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("be2d6a85-9ffd-465d-a25f-8cf39f5b66e7"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
