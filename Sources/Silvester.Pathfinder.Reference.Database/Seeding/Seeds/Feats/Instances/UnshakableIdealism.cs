using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnshakableIdealism : Template
    {
        public static readonly Guid ID = Guid.Parse("714dc374-bbe2-4a3a-a984-1fe45c8bda9d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unshakable Idealism",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("41e68a0d-ddcb-48a1-85e0-0b4e932ef231"), Type = TextBlockType.Text, Text = "Your faith and hope can’t be shaken, and you won’t flee when lives are at stake. You gain a +1 circumstance bonus on saves against (trait: fear) effects and (trait: emotion) effects that inflict despair. When you would gain the fleeing condition, you can choose to stand your ground and be stunned for the effect’s duration as well, preventing you from running and allowing you to re-enter the fight more quickly when the effect ends." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("083d9076-fb56-49e6-96dd-c46f2c1f9bb9"), Feats.Instances.KnightVigilantDedication.ID);
            builder.HaveSpecificSavingThrowSpecificProficiency(Guid.Parse("27856f19-32cb-4196-a4b4-39051c7d4261"), Proficiencies.Instances.Expert.ID, SavingThrowStats.Instances.Will.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("295c033d-714e-4350-ab3b-107ff238cc78"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
