using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VoiceOfTheNight : Template
    {
        public static readonly Guid ID = Guid.Parse("d507be74-7da8-447e-9e81-eb2d0ca23da5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Voice of the Night",
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
            yield return new TextBlock { Id = Guid.Parse("b21e22a4-4af3-44db-8bda-8819878f375d"), Type = TextBlockType.Text, Text = "You hear and understand the words of creatures you share the darkness with. You can ask questions of, receive answers from, and use Diplomacy with bats, rats, and wolves. You also gain a +1 circumstance bonus to (action: Make an Impression) on such animals." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a21bf9b-d94e-4819-a7f1-659e0e83c49d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
