using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WolfStance : Template
    {
        public static readonly Guid ID = Guid.Parse("c97b7a59-59bb-4667-b020-ed38f96cc68a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wolf Stance",
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
            yield return new TextBlock { Id = Guid.Parse("040086be-fa79-4f5a-a926-fee472c5f328"), Type = TextBlockType.Text, Text = "You enter the stance of a wolf, low to the ground with your hands held like fanged teeth. You can make wolf jaw unarmed attacks. These deal 1d8 piercing damage; are in the brawling group; and have the (trait: agile), (trait: backstabber), (trait: finesse), (trait: nonlethal), and (trait: unarmed) traits." };
            yield return new TextBlock { Id = Guid.Parse("65b4caec-a286-4821-bc19-a35fd253437d"), Type = TextBlockType.Text, Text = "If you’re flanking a target while in Wolf Stance, your wolf jaw unarmed attacks also gain the (trait: trip) trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("eec4a28c-832e-4e4b-842b-f0de5ce3cd74"), Feats.Instances.MartialArtistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ba0176f7-a74a-45d6-b1e2-c6295b62eb30"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
