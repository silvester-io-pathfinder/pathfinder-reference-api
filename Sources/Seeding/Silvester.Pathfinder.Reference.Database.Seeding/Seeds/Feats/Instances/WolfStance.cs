using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WolfStance : Template
    {
        public static readonly Guid ID = Guid.Parse("1335aad2-e645-4c4c-931c-a830a1726874");

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
            yield return new TextBlock { Id = Guid.Parse("18554183-fc23-4b35-9e77-3050ba89bf93"), Type = TextBlockType.Text, Text = "You enter the stance of a wolf, low to the ground with your hands held like fanged teeth. You can make wolf jaw unarmed attacks. These deal 1d8 piercing damage; are in the brawling group; and have the (trait: agile), (trait: backstabber), (trait: finesse), (trait: nonlethal), and (trait: unarmed) traits." };
            yield return new TextBlock { Id = Guid.Parse("343dcb9f-5ae5-45b1-a68b-8d65308dfc90"), Type = TextBlockType.Text, Text = "If you’re flanking a target while in Wolf Stance, your wolf jaw unarmed attacks also gain the (trait: trip) trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("29bf4a7f-b265-4666-8efc-f1c78aee0c63"), Feats.Instances.MartialArtistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1dcca7f5-7ecb-4f9f-b396-6d47216a599c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
