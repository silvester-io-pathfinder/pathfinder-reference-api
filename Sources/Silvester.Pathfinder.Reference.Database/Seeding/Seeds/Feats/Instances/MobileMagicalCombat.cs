using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MobileMagicalCombat : Template
    {
        public static readonly Guid ID = Guid.Parse("1ee006e2-a595-4429-b707-dae9f8f435f9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mobile Magical Combat",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("25c3d69b-ebc0-4236-903a-d4d4fcd64283"), Type = TextBlockType.Text, Text = "You dart around the battlefield, casting spells while you carefully make melee attacks with your weapon. (action: Stride) once. If you end your movement within melee reach of at least one enemy, you can make a melee (action: Strike) against that enemy. You can use Mobile Magical Combat while (action: Burrowing | Burrow), (action: Climbing | Climb), (action: Flying | Fly), or (action: Swimming | Swim) instead of (action: Striding | Stride) if you have the corresponding movement type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7b5a4c10-be04-4b34-b3b6-132ed6cf7d55"), Feats.Instances.SpellmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df3422e4-2448-45f6-9f4f-250c9bb6ad2d"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
