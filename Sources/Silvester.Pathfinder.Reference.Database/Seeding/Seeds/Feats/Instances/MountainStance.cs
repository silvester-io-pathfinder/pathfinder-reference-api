using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MountainStance : Template
    {
        public static readonly Guid ID = Guid.Parse("d1b14549-5de8-4d4f-8664-4f2198c12477");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mountain Stance",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("45adb3f1-5155-4851-8102-ce2349300365"), Type = TextBlockType.Text, Text = "You enter the stance of an implacable mountain – a technique first discovered by dwarven monks – allowing you to strike with the weight of an avalanche. The only (action: Strikes | Strike) you can make are falling stone unarmed attacks. These deal 1d8 bludgeoning damage; are in the brawling group; and have the (trait: forceful), (trait: nonlethal), and (trait: unarmed) traits." };
            yield return new TextBlock { Id = Guid.Parse("26676f4d-d623-4286-a929-2bab4b6bd438"), Type = TextBlockType.Text, Text = "While in Mountain Stance, you gain a +4 status bonus to AC and a +2 circumstance bonus to any defenses against being (action: Shoved | Shove) or (action: Tripped | Trip). However, you have a Dexterity modifier cap to your AC of +0, meaning you don’t add your Dexterity to your AC, and your Speeds are all reduced by 5 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8e37bde4-f2bf-4313-8832-9e998abd25e6"), Feats.Instances.MartialArtistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("850200e5-9d6d-4d66-b94a-1612a49d745c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
